from util import hash256
class Block_header:
    def __init__(self, version, prev_hash, merkle_root, timestamp, bits):
        self.version = version
        self.prev_hash = prev_hash
        self.merkle_root = merkle_root
        self.timestamp = timestamp
        self.bits = bits
        self.nonce = 0
        self.hash = ''

    def mine(self):
        while(self.hash[0:4]) != '0' * 4:
            self.hash = hash256((str(self.version) + self.prev_hash + self.merkle_root + str(self.timestamp) + self.bits + str(self.nonce)).encode()).hex()
            self.nonce += 1
            print(f"Mining started {self.nonce}", end='\r')