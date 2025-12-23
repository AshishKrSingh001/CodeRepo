"""
Block class for educational Bitcoin-like blockchain

- Represents a single block in the blockchain
- Stores block metadata, size, transactions, and header
"""

class Block:
    def __init__(self, height, block_size, block_header, tx_count, txns):
        """
        Initialize a block.

        Parameters:
        - height (int): Block height (position in blockchain)
        - block_size (int): Size of the block in bytes
        - block_header (dict): Dictionary of block header information
        - tx_count (int): Number of transactions in the block
        - txns (list): List of transaction dictionaries included in the block
        """
        self.height = height                # Block height
        self.block_size = block_size        # Total size in bytes
        self.block_header = block_header    # Header info (hashes, timestamp, nonce, etc.)
        self.tx_count = tx_count            # Number of transactions
        self.txns = txns                    # List of transactions in dict form
