"""
SendBTC Module
==============
This module allows sending Bitcoin-like transactions within a simplified blockchain system.
It handles UTXOs, prepares transaction inputs and outputs, calculates fees, and signs transactions
using the private key associated with the sender's address.
"""

import time
from util import decode_base58
from script import Script
from transaction import Tx, Tx_in, Tx_out
from database import Account_DB
from ECC import PrivateKey

class SendBTC:
    """
    Handles sending BTC from one account to another.

    Attributes:
        COIN (int): The number of satoshis in one coin (1 BTC = 10^8 satoshis)
        from_public_address (str): Sender's public Bitcoin address
        to_account (str): Recipient's public Bitcoin address
        amount (float): Amount of BTC to send
        utxos (dict): Unspent transaction outputs
    """

    def __init__(self, from_account, to_account, amount, UTXOS):
        self.COIN = 10**8  # 1 BTC = 100,000,000 satoshis
        self.from_public_address = from_account
        self.to_account = to_account
        self.amount = int(amount * self.COIN)  # convert to satoshis
        self.utxos = UTXOS  # dictionary of UTXOs
        self.tx_ins = []
        self.tx_outs = []
        self.fee = 0
        self.total = 0
        self.change_amount = 0
        self.is_balance_enough = False

    def script_pubkey(self, public_address):
        """
        Converts a public address to a scriptPubKey (locking script).

        Args:
            public_address (str): Bitcoin address

        Returns:
            Script: P2PKH locking script
        """
        h160 = decode_base58(public_address)
        return Script().p2pkh_script(h160)

    def get_private_key(self):
        """
        Retrieves the private key associated with the sender's public address.

        Returns:
            int: Private key as integer
        Raises:
            ValueError: If no matching account or private key is found
        """
        all_accounts = Account_DB().read() or []
        for account in all_accounts:
            if account['public_address'] == self.from_public_address:
                secret = account.get('private_key')
                if secret is None:
                    raise ValueError(f"Private key not found for address {self.from_public_address}")
                return secret
        raise ValueError(f"No account found with address {self.from_public_address}")

    def prepare_tx_in(self):
        """
        Prepares transaction inputs by finding UTXOs associated with the sender's address.

        Returns:
            list: List of Tx_in objects
        """
        tx_ins = []
        self.total = 0

        # Convert sender address to public key hash
        self.from_address_script_pubkey = self.script_pubkey(self.from_public_address)
        self.from_public_hash = self.from_address_script_pubkey.cmds[2]

        # Wait until UTXOs are available (converted to normal dict)
        new_utxos = {}
        try:
            while not new_utxos:
                new_utxos = dict(self.utxos)
                time.sleep(1)
        except Exception as e:
            print(f"Error converting UTXOs to dict: {e}")

        # Iterate over UTXOs to gather enough funds
        for tx_id, tx_obj in new_utxos.items():
            if self.total >= self.amount:
                break

            for index, tx_out in enumerate(tx_obj.tx_outs):
                if tx_out.script_pubkey.cmds[2] == self.from_public_hash:
                    self.total += tx_out.amount
                    prev_tx = bytes.fromhex(tx_obj.id())
                    tx_ins.append(Tx_in(prev_tx, index))

        self.is_balance_enough = self.total >= self.amount
        return tx_ins

    def prepare_tx_out(self):
        """
        Prepares transaction outputs, including change and fees.

        Returns:
            list: List of Tx_out objects
        """
        tx_outs = []

        # Output to recipient
        to_script_pubkey = self.script_pubkey(self.to_account)
        tx_outs.append(Tx_out(self.amount, to_script_pubkey))

        # Fee
        self.fee = self.COIN  # 1 satoshi fee (simplified)
        self.change_amount = self.total - self.amount - self.fee

        # Return change to sender if any
        if self.change_amount > 0:
            tx_outs.append(Tx_out(self.change_amount, self.from_address_script_pubkey))

        return tx_outs

    def sign_tx(self):
        """
        Signs the transaction inputs with the sender's private key.

        Raises:
            ValueError: If the private key is None
        """
        secret = self.get_private_key()  # retrieves private key safely
        private_key = PrivateKey(secret=secret)  # create PrivateKey object

        for index, tx_input in enumerate(self.tx_ins):
            self.tx_obj.sign_input(index, private_key, self.from_address_script_pubkey)

        return True

    def prepare_transaction(self):
        """
        Prepares the full transaction including inputs, outputs, and signing.

        Returns:
            Tx: Signed transaction object if balance is enough
            False: If balance is insufficient
        """
        self.tx_ins = self.prepare_tx_in()

        if not self.is_balance_enough:
            print("Insufficient balance to perform transaction.")
            return False

        self.tx_outs = self.prepare_tx_out()
        self.tx_obj = Tx(1, self.tx_ins, self.tx_outs, 0)
        self.tx_obj.tx_id = self.tx_obj.id()
        self.sign_tx()

        return self.tx_obj
