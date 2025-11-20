from block import Block
from util import hash256
from block_header import Block_header
from database import Blockchain_db
from tx import CoinbaseTx
import time

ZERO_HASH = '0' * 64
VERSION = 1

class Blockchain:
    def __init__(self):
        self.chain = []

    def write_on_disk(self, block):
        blockchain_db = Blockchain_db()
        blockchain_db.write(block)
    def fetch_last_block(self):
        blockchain_db = Blockchain_db()
        return blockchain_db.last_block()

    def genesis_block(self):
        block_height = 0
        prev_hash = ZERO_HASH
        self.add_block(block_height, prev_hash)

    def add_block(self, block_height, prev_hash):
        timestamp = int(time.time())

        coinbase_instance = CoinbaseTx(block_height)
        coinbase_tx = coinbase_instance.coinbase_transaction()

        merkle_root = coinbase_tx.tx_id
        bits = 'ffff001f'
        block_header = Block_header(VERSION, prev_hash, merkle_root, timestamp, bits)
        block_header.mine()
        print(f"Block {block_height} mined successfully with nonce value of {block_header.nonce}")
        self.write_on_disk([Block(block_height, 1, block_header.__dict__, 1, coinbase_tx.to_dict()).__dict__])

    def main(self):
        last_block = self.fetch_last_block()
        if last_block is None:
            self.genesis_block()
        while True:
            last_block = self.fetch_last_block()
            block_height = last_block['height'] + 1
            prev_hash = last_block['block_header']['hash']
            self.add_block(block_height, prev_hash)

if __name__ == "__main__":
    blockchain = Blockchain()
    blockchain.main()