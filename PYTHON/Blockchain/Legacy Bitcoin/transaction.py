# transaction.py
# This file contains classes and methods for Bitcoin transactions,
# including coinbase transactions, normal transactions, inputs, and outputs.

import json
from script import Script
from util import *
from account import ensure_account

ZERO_HASH = b'\0' * 32  # 32-byte zero hash for coinbase prev_tx
VERSION = 1              # Transaction version
REWARD = 50              # Coinbase reward in BTC
SIGH_HASH_ALL = 1        # Standard SIGHASH type



# -------------------------------
# Coinbase Transaction
# -------------------------------
class Coinbase:
    """
    Handles creation of a coinbase transaction (miner's reward).
    """
    def __init__(self, block_height: int):
        # Convert block height to little-endian bytes
        self.block_height_in_little_endian = int_to_little_endian(
            block_height, bytes_needed(block_height)
        )
        # Load miner account
        self.account = ensure_account()

    def coinbase_transaction(self):
        """
        Creates a coinbase transaction.
        Returns a Tx object representing the coinbase transaction.
        """
        # Input
        tx_ins = []
        prev_tx = ZERO_HASH
        prev_index = 0xffffffff
        tx_in = Tx_in(prev_tx, prev_index)
        tx_in.script_sig.cmds.append(self.block_height_in_little_endian)
        tx_ins.append(tx_in)

        # Output
        tx_outs = []
        target_amount = REWARD * (10**8)  # Convert BTC to satoshis
        miner_address = self.account["public_address"]
        target_h160 = decode_base58(miner_address)
        target_script = Script().p2pkh_script(target_h160)
        tx_outs.append(Tx_out(target_amount, target_script))

        # Create Tx
        coinbase_tx = Tx(VERSION, tx_ins, tx_outs, 0)
        coinbase_tx.tx_id = coinbase_tx.id()
        return coinbase_tx


# -------------------------------
# Transaction
# -------------------------------
class Tx:
    """
    Represents a Bitcoin transaction.
    """
    def __init__(self, version, tx_ins, tx_outs, locktime):
        self.version = version
        self.tx_ins = tx_ins
        self.tx_outs = tx_outs
        self.locktime = locktime

    def id(self):
        """Returns transaction id as hex string"""
        return self.hash().hex()

    def hash(self):
        """Binary hash of the transaction (double SHA256)"""
        return hash256(self.serialize())[::-1]

    def serialize(self):
        """Serializes the transaction for hashing or broadcasting"""
        result = int_to_little_endian(self.version, 4)
        result += encode_varient(len(self.tx_ins))
        for tx_in in self.tx_ins:
            result += tx_in.serialize()
        result += encode_varient(len(self.tx_outs))
        for tx_out in self.tx_outs:
            result += tx_out.serialize()
        result += int_to_little_endian(self.locktime, 4)
        return result

    def is_coinbase(self):
        """Checks if the transaction is a coinbase transaction"""
        if len(self.tx_ins) == 1:
            tx_in = self.tx_ins[0]
            return tx_in.prev_tx == ZERO_HASH and tx_in.prev_index == 0xffffffff
        return False

    def to_dict(self):
        """Converts transaction to dictionary format (for JSON or debugging)"""
        for i, tx_in in enumerate(self.tx_ins):
            if self.is_coinbase():
                # Convert little-endian height to int
                tx_in.script_sig.cmds[0] = little_endian_to_int(tx_in.script_sig.cmds[0])
            tx_in.prev_tx = tx_in.prev_tx.hex()
            for j, cmd in enumerate(tx_in.script_sig.cmds):
                if isinstance(cmd, bytes):
                    tx_in.script_sig.cmds[j] = cmd.hex()
            tx_in.script_sig = tx_in.script_sig.__dict__
            self.tx_ins[i] = tx_in.__dict__

        for i, tx_out in enumerate(self.tx_outs):
            tx_out.script_pubkey.cmds[2] = tx_out.script_pubkey.cmds[2].hex()
            tx_out.script_pubkey = tx_out.script_pubkey.__dict__
            self.tx_outs[i] = tx_out.__dict__

        return self.__dict__

    def sign_hash(self, input_index, script_pubkey):
        """Returns the integer hash (z) of the transaction for signing a specific input"""
        s = int_to_little_endian(self.version, 4)
        s += encode_varient(len(self.tx_ins))
        for i, tx_in in enumerate(self.tx_ins):
            if i == input_index:
                s += Tx_in(tx_in.prev_tx, tx_in.prev_index, script_pubkey).serialize()
            else:
                s += Tx_in(tx_in.prev_tx, tx_in.prev_index).serialize()
        s += encode_varient(len(self.tx_outs))
        for tx_out in self.tx_outs:
            s += tx_out.serialize()
        s += int_to_little_endian(self.locktime, 4)
        s += int_to_little_endian(SIGH_HASH_ALL, 4)
        return int.from_bytes(hash256(s), 'big')

    def sign_input(self, input_index, private_key, script_pubkey):
        """Signs a transaction input with the provided private key"""
        z = self.sign_hash(input_index, script_pubkey)
        der = private_key.sign(z).der()
        sig = der + SIGH_HASH_ALL.to_bytes(1, 'big')
        sec = private_key.point.sec()
        self.tx_ins[input_index].script_sig = Script([sig, sec])

    def verify_input(self, input_index, script_pubkey):
        """Verifies a transaction input signature"""
        tx_in = self.tx_ins[input_index]
        z = self.sign_hash(input_index, script_pubkey)
        combined = tx_in.script_sig + script_pubkey
        return combined.evaluate(z)


# -------------------------------
# Transaction Input
# -------------------------------
class Tx_in:
    """Represents a transaction input"""
    def __init__(self, prev_tx, prev_index, script_sig=None, sequence=0xffffffff):
        self.prev_tx = prev_tx
        self.prev_index = prev_index
        self.script_sig = Script() if script_sig is None else script_sig
        self.sequence = sequence

    def serialize(self):
        """Serializes the transaction input"""
        result = self.prev_tx[::-1]
        result += int_to_little_endian(self.prev_index, 4)
        result += self.script_sig.serialize()
        result += int_to_little_endian(self.sequence, 4)
        return result


# -------------------------------
# Transaction Output
# -------------------------------
class Tx_out:
    """Represents a transaction output"""
    def __init__(self, amount, script_pubkey):
        self.amount = amount
        self.script_pubkey = script_pubkey

    def serialize(self):
        """Serializes the transaction output"""
        result = int_to_little_endian(self.amount, 8)
        result += self.script_pubkey.serialize()
        return result
