"""
Blockchain simulation for educational Bitcoin-like system (pre-SegWit, ECDSA era)
- UTXO-based
- Proof-of-Work (PoW)
- Mempool-driven block creation
- Difficulty adjustment like Bitcoin
- Automatic state saving and disk persistence
"""

import time
from multiprocessing import Manager, Process
from block_header import Block_Header
from block import Block
from transaction import Coinbase
from database import Blockchain_DB
from util import merkle_root, target_to_bits
from run import main
from state_io import load_state, save_state
from account import ensure_account

# -------------------------------
# Constants
# -------------------------------

ZERO_HASH = '0' * 64
VERSION = 1

# Difficulty parameters
INITIAL_TARGET = 0x0000FFFF00000000000000000000000000000000000000000000000000000000
BLOCK_INTERVAL = 20              # seconds per block
ADJUSTMENT_INTERVAL = 5          # blocks per difficulty adjustment

# Block size limit (pre-SegWit)
MAX_BLOCK_SIZE = 1_000_000       # 1 MB


# -------------------------------
# Blockchain Class
# -------------------------------

class Blockchain:
    """
    A Bitcoin-like educational blockchain class with:
    - Block creation
    - Transaction handling from mempool
    - Fee calculation
    - Difficulty adjustment
    - Automatic UTXO updates
    """

    def __init__(self, utxos, mempool):
        self.utxos = utxos                # UTXO set (shared memory)
        self.mempool = mempool            # Unconfirmed transactions (shared memory)
        self.current_target = INITIAL_TARGET
        self.bits = target_to_bits(INITIAL_TARGET)

    # ----------------------------------------------------
    # Difficulty adjustment
    # ----------------------------------------------------
    def adjust_target(self, last_block, first_block):
        """
        Adjusts mining target based on the time it took to mine the last interval of blocks
        """
        actual_time = (
            last_block['block_header']['timestamp']
            - first_block['block_header']['timestamp']
        )
        expected_time = BLOCK_INTERVAL * ADJUSTMENT_INTERVAL

        # Clamp adjustment between 1/4 and 4x (Bitcoin rule)
        actual_time = max(expected_time // 4, min(actual_time, expected_time * 4))

        self.current_target = self.current_target * actual_time // expected_time
        self.bits = target_to_bits(self.current_target)

    # ----------------------------------------------------
    # Select transactions from mempool
    # ----------------------------------------------------
    def read_transaction_from_memorypool(self):
        """
        Select transactions from the mempool until block size limit is reached
        """
        self.txids = []
        self.add_txn_in_block = []
        self.spent_inputs = []
        self.block_size = 80  # Block header size in bytes

        for txid in list(self.mempool.keys()):
            tx = self.mempool[txid]
            tx_size = len(tx.serialize())

            if self.block_size + tx_size > MAX_BLOCK_SIZE:
                break  # Stop if block size limit is exceeded

            self.txids.append(bytes.fromhex(txid))
            self.add_txn_in_block.append(tx)
            self.block_size += tx_size

            for txin in tx.tx_ins:
                self.spent_inputs.append((txin.prev_tx, txin.prev_index))

    # ----------------------------------------------------
    # Fee calculation
    # ----------------------------------------------------
    def calculate_fee(self):
        """
        Calculate total transaction fees for the block
        Fee = Sum(inputs) - Sum(outputs)
        """
        total_inputs = 0
        total_outputs = 0

        # Sum all input amounts from UTXOs
        for prev_tx, index in self.spent_inputs:
            txid = prev_tx.hex()
            if txid in self.utxos:
                total_inputs += self.utxos[txid].tx_outs[index].amount

        # Sum all outputs in selected transactions
        for tx in self.add_txn_in_block:
            for tx_out in tx.tx_outs:
                total_outputs += tx_out.amount

        self.fee = total_inputs - total_outputs

        if self.fee < 0:
            raise ValueError("Invalid block: negative fee")

    # ----------------------------------------------------
    # Update UTXOs after mining
    # ----------------------------------------------------
    def update_utxos(self):
        """
        Updates the UTXO set after adding a block:
        - Remove spent outputs
        - Add new outputs
        """
        # Remove spent outputs
        for prev_tx, index in self.spent_inputs:
            txid = prev_tx.hex()
            if txid in self.utxos:
                del self.utxos[txid].tx_outs[index]
                if not self.utxos[txid].tx_outs:
                    del self.utxos[txid]

        # Add new outputs
        for tx in self.add_txn_in_block:
            self.utxos[tx.tx_id] = tx

    # ----------------------------------------------------
    # Block creation
    # ----------------------------------------------------
    def add_block(self, height, prev_hash):
        """
        Create and mine a new block
        """
        self.read_transaction_from_memorypool()
        self.calculate_fee()

        timestamp = int(time.time())

        # Create coinbase transaction and include fees
        coinbase = Coinbase(height).coinbase_transaction()
        coinbase.tx_outs[0].amount += self.fee

        self.txids.insert(0, bytes.fromhex(coinbase.tx_id))
        self.add_txn_in_block.insert(0, coinbase)
        self.block_size += len(coinbase.serialize())

        merkle = merkle_root(self.txids)[::-1].hex()

        # Create block header
        header = Block_Header(VERSION, prev_hash, merkle, timestamp, self.bits)
        header.mine(self.current_target)  # Proof-of-Work mining

        # Update UTXOs and remove included transactions from mempool
        self.update_utxos()
        self.remove_from_mempool()

        # Create block object and save to disk
        block = Block(
            height,
            self.block_size,
            header.__dict__,
            len(self.add_txn_in_block),
            [tx.to_dict() for tx in self.add_txn_in_block]
        )

        Blockchain_DB().write([block.__dict__])
        save_state(self.utxos, self.mempool)  # Auto save

        # Print block info
        print(
            f"✔ Block {height} | "
            f"hash={header.hash[:16]}... | "
            f"nonce={header.nonce} | "
            f"diff={hex(self.current_target)[2:10]} | "
            f"txs={len(self.add_txn_in_block)} | "
            f"fees={self.fee}"
        )

    # ----------------------------------------------------
    # Remove transactions from mempool
    # ----------------------------------------------------
    def remove_from_mempool(self):
        for txid in self.txids:
            self.mempool.pop(txid.hex(), None)

    # ----------------------------------------------------
    # Create genesis block
    # ----------------------------------------------------
    def genesis_block(self):
        self.add_block(0, ZERO_HASH)

    # ----------------------------------------------------
    # Main blockchain loop
    # ----------------------------------------------------
    def main(self):
        ensure_account()
        db = Blockchain_DB()
        if db.lastblock() is None:
            self.genesis_block()

        while True:
            last = db.lastblock()
            height = last['height'] + 1
            prev_hash = last['block_header']['hash']

            self.add_block(height, prev_hash)

            if height % ADJUSTMENT_INTERVAL == 0:
                first = db.get_block(height - ADJUSTMENT_INTERVAL)
                last = db.get_block(height - 1)
                self.adjust_target(last, first)


# -------------------------------
# Run blockchain with multiprocessing
# -------------------------------
if __name__ == "__main__":
    with Manager() as manager:
        # Load persisted UTXOs and mempool from disk
        utxos_disk, mempool_disk = load_state()

        # Shared memory dictionaries
        utxos = manager.dict(utxos_disk)
        mempool = manager.dict(mempool_disk)

        # Start Flask web app in separate process
        web_app = Process(target=main, args=(utxos, mempool))
        web_app.start()

        # Start blockchain mining loop
        blockchain = Blockchain(utxos, mempool)
        blockchain.main()
