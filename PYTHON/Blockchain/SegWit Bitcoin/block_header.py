"""
Block_Header class for educational Bitcoin-like blockchain

- Represents the metadata of a block (header)
- Includes mining (Proof-of-Work) logic
"""

from util import hash256, little_endian_to_int, int_to_little_endian

class Block_Header:
    def __init__(self, version, prev_hash, merkle_root, timestamp, bits):
        """
        Initialize a block header.

        Parameters:
        - version (int): Block version
        - prev_hash (str): Previous block hash (hex string)
        - merkle_root (str): Merkle root of transactions (hex string)
        - timestamp (int): Block creation time (unix timestamp)
        - bits (bytes): Encoded target difficulty
        """
        self.version = version            # Block version
        self.prev_hash = prev_hash        # Previous block hash
        self.merkle_root = merkle_root    # Merkle root of transactions
        self.timestamp = timestamp        # Timestamp of block creation
        self.bits = bits                  # Difficulty target in bytes
        self.nonce = 0                    # Nonce for mining
        self.hash = ''                    # Final block hash (hex string)

    def mine(self, target):
        """
        Perform Proof-of-Work mining until the block hash is less than the target.

        Parameters:
        - target (int): Target difficulty as integer
        """
        self.hash = target + 1  # Initialize hash higher than target

        # Keep iterating until a valid hash is found
        while self.hash > target:
            # Serialize block header for hashing
            header_bytes = (
                int_to_little_endian(self.version, 4)
                + bytes.fromhex(self.prev_hash)[::-1]
                + bytes.fromhex(self.merkle_root)
                + int_to_little_endian(self.timestamp, 4)
                + self.bits
                + int_to_little_endian(self.nonce, 4)
            )

            # Compute double SHA256 hash
            self.hash = little_endian_to_int(hash256(header_bytes))

            # Increment nonce for next iteration
            self.nonce += 1

            # Print mining progress (same line)
            print(f"Mining Started {self.nonce}", end="\r")

        # Once valid hash is found, convert to hex and reverse bytes for display
        self.hash = int_to_little_endian(self.hash, 32).hex()[::-1]
        self.bits = self.bits.hex()  # Convert bits to hex string
