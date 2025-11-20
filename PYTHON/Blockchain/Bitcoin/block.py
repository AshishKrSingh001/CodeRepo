class Block:
    """
    Block is a storage container that stores transactions
    """
    def __init__(self, height, block_size, block_header, tx_count, txs):
        self.height = height
        self.block_size = block_size
        self.block_header = block_header
        self.tx_count = tx_count
        self.txs = txs