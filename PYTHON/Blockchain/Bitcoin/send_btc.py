import time
from util import decode_base58
from script import Script
from tx import Tx, Tx_in, Tx_out
from database import Account_db
from EllepticCurve.EllepticCurve import PrivateKey

class Send_btc:
    def __init__(self, from_account, to_account, amount, UTXOS):
        self.COIN = 100000000
        self.from_public_address = from_account
        self.to_account = to_account
        self.amount = amount * self.COIN
        self.UTXOS = UTXOS

    def script_pubkey(self, public_address):
        h160 = decode_base58(public_address)
        script_pubkey = Script().p2pkh_script(h160)
        return script_pubkey

    def prepare_tx_in(self):
        tx_ins = []
        self.total = 0
        
        """Convert Public address into public hash to find tx_outs that are locked to this hash"""

        self.from_address_script_pubkey = self.script_pubkey(self.from_public_address)
        self.from_public_key_hash = self.from_address_script_pubkey.cmds[2]

        newUTXOS = {}

        try:
            while len(newUTXOS) < 1:
                newUTXOS = dict(self.UTXOS)
                time.sleep(2)
        except Exception as e:
            print(f"Error in converting the managed DICT to Normal Dict: {e}")
        
        for tx_byte in newUTXOS:
            if self.total < self.amount:
                tx_obj = newUTXOS[tx_byte]
            
            for index, tx_out in enumerate(tx_obj.tx_outs):
                if tx_out.script_pubkey.cmds[2] == self.from_public_key_hash:
                    self.total += tx_out.amount
                    prev_tx = bytes.fromhex(tx_obj.id())
                    tx_ins.append(Tx_in(prev_tx, index))

            else:
                break

        self.is_balance_enough = True
        if self.total < self.amount:
            self.is_balance_enough = False

        return tx_ins

    def prepare_tx_out(self):
        tx_outs = []

        to_script_pubkey = self.script_pubkey(self.to_account)
        tx_outs.append(Tx_out(self.amount, to_script_pubkey))

        """Calculate the fee"""
        self.fee = self.COIN
        self.change_amount = self.total - self.amount - self.fee

        tx_outs.append(Tx_out(self.change_amount, self.from_address_script_pubkey))

        return tx_outs
    
    def sign_transaction(self):
        secret = self.get_private_key()
        prev = PrivateKey(secret=secret)

        for index, input in enumerate(self.tx_ins):
            self.tx_obj.sign_input(index, prev, self.from_address_script_pubkey)

        return True

    def get_private_key(self):
        all_accounts = Account_db().read()
        for account in all_accounts:
            if account['public_address'] == self.from_public_address:
                return account['private_key']


    def prepare_transaction(self):
        self.tx_ins = self.prepare_tx_in()
        if self.is_balance_enough:
            self.tx_outs = self.prepare_tx_out()
            self.tx_obj = Tx(1, self.tx_ins, self.tx_outs, 0)
            self.sign_transaction()
            return True
        
        return False
