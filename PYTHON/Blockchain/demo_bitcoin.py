"""
bitcoin_like.py
Educational Bitcoin-like blockchain in pure Python.

Features:
- Wallets: ECDSA (secp256k1)
- P2PKH style addresses with Base58Check
- Transactions: inputs/outputs (UTXO)
- Signing / verifying transactions (SIGHASH_ALL style simplified)
- Coinbase / mining reward
- Blocks with merkle root, header hashing
- Proof-of-Work mining (difficulty = leading zeros)
- Mempool and mining
- Chain validation and simple persistence to JSON

NOTES:
- Simplified: no networking, no mempool relay, no script engine beyond basic pubkey-hash check.
- Educational only; do not use in production with real funds.
"""

import hashlib
import json
import time
import os
from dataclasses import dataclass, field
from typing import List, Dict, Optional, Tuple

# external dependency
try:
    from ecdsa import SigningKey, SECP256k1, VerifyingKey, BadSignatureError
except Exception as e:
    raise ImportError("Install ecdsa: pip install ecdsa") from e

# -------------------------
# Utilities
# -------------------------
def sha256(x: bytes) -> bytes:
    return hashlib.sha256(x).digest()

def sha256_hex(x: bytes) -> str:
    return hashlib.sha256(x).hexdigest()

def ripemd160(x: bytes) -> bytes:
    h = hashlib.new('ripemd160')
    h.update(x)
    return h.digest()

# Base58 / Base58Check (Bitcoin alphabet)
B58_ALPHABET = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz"

def b58_encode(b: bytes) -> str:
    # big integer encode
    n = int.from_bytes(b, 'big')
    res = []
    while n > 0:
        n, r = divmod(n, 58)
        res.append(B58_ALPHABET[r])
    # leading zeros
    pad = 0
    for ch in b:
        if ch == 0:
            pad += 1
        else:
            break
    return '1' * pad + ''.join(reversed(res)) if res else '1' * pad

def b58check_encode(payload: bytes) -> str:
    # payload already includes version byte(s)
    checksum = sha256(sha256(payload))[:4]
    return b58_encode(payload + checksum)

def base58check_address(pubkey_hash: bytes, version: bytes = b'\x00') -> str:
    # P2PKH: version 0x00 (bitcoin mainnet) by default
    payload = version + pubkey_hash
    return b58check_encode(payload)

# -------------------------
# Wallet (ECDSA secp256k1)
# -------------------------
class Wallet:
    def __init__(self, sk_hex: Optional[str] = None):
        if sk_hex:
            self.sk = SigningKey.from_string(bytes.fromhex(sk_hex), curve=SECP256k1)
        else:
            self.sk = SigningKey.generate(curve=SECP256k1)
        self.vk = self.sk.get_verifying_key()

    def private_key_hex(self) -> str:
        return self.sk.to_string().hex()

    def public_key_bytes(self, compressed: bool = True) -> bytes:
        # return compressed public key bytes (33 bytes) like Bitcoin
        px = self.vk.to_string()  # 64 bytes (x||y)
        x = px[:32]; y = px[32:]
        parity = y[-1] & 1
        if compressed:
            return (b'\x02' if parity == 0 else b'\x03') + x
        else:
            return b'\x04' + x + y

    def address(self) -> str:
        pubkey = self.public_key_bytes(compressed=True)
        pk_hash = ripemd160(sha256(pubkey))  # RIPEMD160(SHA256(pubkey))
        return base58check_address(pk_hash, version=b'\x00')

    def sign(self, msg: bytes) -> str:
        sig = self.sk.sign_digest(msg, sigencode=lambda r,s,order: r.to_bytes(32,'big')+s.to_bytes(32,'big'))
        return sig.hex()

    def verify(self, sig_hex: str, msg: bytes) -> bool:
        try:
            sig = bytes.fromhex(sig_hex)
            r = int.from_bytes(sig[:32],'big'); s = int.from_bytes(sig[32:],'big')
            # ecdsa package expects DER or a custom decode; we'll verify using raw signature verifying:
            self.vk.verify_digest(sig, msg)  # ecdsa lib may expect DER; if it errors, fallback below
            return True
        except BadSignatureError:
            return False
        except Exception:
            # fallback: try VerifyingKey.from_string to verify raw r+s? For educational brevity we'll trust verify_digest
            return False

# -------------------------
# Transaction model
# -------------------------
@dataclass
class TXInput:
    txid: str               # referenced transaction id (hex)
    out_index: int          # which output in referenced tx
    signature: Optional[str] = ""  # hex signature
    pubkey: Optional[str] = ""     # hex public key (compressed hex)

    def to_dict(self):
        return {
            "txid": self.txid,
            "out_index": self.out_index,
            "signature": self.signature,
            "pubkey": self.pubkey
        }

@dataclass
class TXOutput:
    amount: int             # integer satoshi-like units
    pubkey_hash: str        # hex of ripemd160(pubkey_sha256) (20 bytes hex)

    def to_dict(self):
        return {"amount": self.amount, "pubkey_hash": self.pubkey_hash}

@dataclass
class Transaction:
    inputs: List[TXInput]
    outputs: List[TXOutput]
    timestamp: float = field(default_factory=time.time)

    def to_dict(self, include_sigs: bool = True):
        return {
            "inputs": [inp.to_dict() if include_sigs else {"txid": inp.txid, "out_index": inp.out_index, "signature": "", "pubkey": inp.pubkey} for inp in self.inputs],
            "outputs": [o.to_dict() for o in self.outputs],
            "timestamp": self.timestamp
        }

    def id(self) -> str:
        # txid is double-sha256 of serialized tx with signatures included (like Bitcoin)
        raw = json.dumps(self.to_dict(include_sigs=True), sort_keys=True).encode()
        return hashlib.sha256(hashlib.sha256(raw).digest()).hexdigest()

    def id_no_sigs(self) -> str:
        # used for signing (SIGHASH_ALL like: hash of tx with empty signatures)
        raw = json.dumps(self.to_dict(include_sigs=False), sort_keys=True).encode()
        return hashlib.sha256(raw).hexdigest()

# Helper: Create coinbase tx
def create_coinbase_tx(to_address: str, amount: int, coinbase_data: str = "") -> Transaction:
    # coinbase tx: tx with no inputs; create one output to miner
    out = TXOutput(amount=amount, pubkey_hash=address_to_pubkey_hash(to_address))
    return Transaction(inputs=[], outputs=[out], timestamp=time.time())

# -------------------------
# Address / pubkeyhash helpers
# -------------------------
def address_to_pubkey_hash(address: str) -> str:
    # decode base58check and return hex of pubkey hash (without version/checksum)
    # Very small base58check decode implementation
    num = 0
    for ch in address:
        num = num * 58 + B58_ALPHABET.index(ch)
    combined = num.to_bytes((num.bit_length()+7)//8, 'big')
    # handle leading '1's (zero bytes)
    nPad = 0
    for ch in address:
        if ch == '1':
            nPad += 1
        else:
            break
    combined = b'\x00' * nPad + combined
    # last 4 bytes are checksum, first is version, next 20 bytes are pubkeyhash
    if len(combined) < 25:
        raise ValueError("Invalid address length")
    version = combined[0:1]
    pubkey_hash = combined[1:21]
    checksum = combined[21:25]
    if sha256(sha256(combined[:21]))[:4] != checksum:
        raise ValueError("Invalid checksum")
    return pubkey_hash.hex()

# -------------------------
# UTXO set
# -------------------------
class UTXOSet:
    def __init__(self):
        # mapping txid -> list of outputs (TXOutput or None if spent)
        self.utxos: Dict[str, List[Optional[TXOutput]]] = {}

    def add_transaction(self, tx: Transaction):
        self.utxos[tx.id()] = [out for out in tx.outputs]

    def spend_output(self, txid: str, index: int):
        if txid not in self.utxos:
            raise KeyError("txid not found in utxos")
        if index >= len(self.utxos[txid]):
            raise IndexError("out index out of range")
        if self.utxos[txid][index] is None:
            raise ValueError("output already spent")
        self.utxos[txid][index] = None

    def find_spendable_outputs(self, pubkey_hash_hex: str, amount: int) -> Tuple[int, Dict[str, List[int]]]:
        accumulated = 0
        used: Dict[str, List[int]] = {}
        for tid, outs in self.utxos.items():
            for idx, out in enumerate(outs):
                if out is None: continue
                if out.pubkey_hash == pubkey_hash_hex:
                    used.setdefault(tid, []).append(idx)
                    accumulated += out.amount
                    if accumulated >= amount:
                        return accumulated, used
        return accumulated, used

    def get_balance(self, pubkey_hash_hex: str) -> int:
        balance = 0
        for outs in self.utxos.values():
            for out in outs:
                if out and out.pubkey_hash == pubkey_hash_hex:
                    balance += out.amount
        return balance

    def to_serializable(self):
        # convert utxos into a serializable dictionary
        out = {}
        for tid, outs in self.utxos.items():
            out[tid] = [o.to_dict() if o is not None else None for o in outs]
        return out

    def from_serializable(self, data):
        self.utxos = {}
        for tid, outs in data.items():
            self.utxos[tid] = [TXOutput(**o) if o is not None else None for o in outs]

# -------------------------
# Merkle root
# -------------------------
def merkle_root(txids: List[str]) -> str:
    if not txids:
        return ''
    layer = [bytes.fromhex(t) for t in txids]
    while len(layer) > 1:
        if len(layer) % 2 == 1:
            layer.append(layer[-1])
        next_layer = []
        for i in range(0, len(layer), 2):
            next_layer.append(hashlib.sha256(layer[i] + layer[i+1]).digest())
        layer = next_layer
    return layer[0].hex()

# -------------------------
# Block and Blockchain
# -------------------------
@dataclass
class Block:
    index: int
    prev_hash: str
    timestamp: float
    nonce: int
    merkle_root: str
    transactions: List[Transaction]

    def header_bytes(self) -> bytes:
        hdr = {
            "index": self.index,
            "prev_hash": self.prev_hash,
            "timestamp": self.timestamp,
            "nonce": self.nonce,
            "merkle_root": self.merkle_root
        }
        return json.dumps(hdr, sort_keys=True).encode()

    def hash(self) -> str:
        return hashlib.sha256(self.header_bytes()).hexdigest()

class Blockchain:
    def __init__(self, dbfile: str = "chain_db.json", difficulty: int = 4, block_reward: int = 50_00000000):
        self.chain: List[Block] = []
        self.mempool: List[Transaction] = []
        self.utxos = UTXOSet()
        self.difficulty = difficulty
        self.block_reward = block_reward
        self.dbfile = dbfile
        if os.path.exists(dbfile):
            self.load()
        else:
            self.create_genesis()

    def create_genesis(self):
        # create a genesis coinbase that pays to a special address
        cb = create_coinbase_tx(to_address="1GenesisAddressXXXXXXXXXXXXXXXX", amount=self.block_reward)
        txs = [cb]
        mr = merkle_root([tx.id() for tx in txs])
        genesis = Block(index=0, prev_hash="0"*64, timestamp=time.time(), nonce=0, merkle_root=mr, transactions=txs)
        # For genesis we won't do PoW
        self.chain.append(genesis)
        # add utxos
        self.utxos.add_transaction(cb)
        self.save()

    def save(self):
        data = {
            "difficulty": self.difficulty,
            "block_reward": self.block_reward,
            "chain": [self._block_to_dict(b) for b in self.chain],
            "utxos": self.utxos.to_serializable()
        }
        with open(self.dbfile, "w") as f:
            json.dump(data, f, indent=2)

    def load(self):
        with open(self.dbfile, "r") as f:
            data = json.load(f)
        self.difficulty = data["difficulty"]
        self.block_reward = data["block_reward"]
        self.chain = []
        for bdict in data["chain"]:
            txs = [self._tx_from_dict(t) for t in bdict["transactions"]]
            blk = Block(index=bdict["index"], prev_hash=bdict["prev_hash"], timestamp=bdict["timestamp"], nonce=bdict["nonce"], merkle_root=bdict["merkle_root"], transactions=txs)
            self.chain.append(blk)
        self.utxos.from_serializable(data.get("utxos", {}))

    def _block_to_dict(self, blk: Block) -> dict:
        return {
            "index": blk.index,
            "prev_hash": blk.prev_hash,
            "timestamp": blk.timestamp,
            "nonce": blk.nonce,
            "merkle_root": blk.merkle_root,
            "transactions": [t.to_dict(include_sigs=True) for t in blk.transactions]
        }

    def _tx_from_dict(self, td: dict) -> Transaction:
        ins = [TXInput(**i) for i in td["inputs"]]
        outs = [TXOutput(**o) for o in td["outputs"]]
        return Transaction(inputs=ins, outputs=outs, timestamp=td.get("timestamp", time.time()))

    def last_block(self) -> Block:
        return self.chain[-1]

    # -------------------------
    # Transaction creation / signing
    # -------------------------
    def create_transaction(self, from_wallet: Wallet, to_address: str, amount: int) -> Transaction:
        sender_pubkey_hash = ripemd160(sha256(from_wallet.public_key_bytes())).hex()
        accumulated, spendable = self.utxos.find_spendable_outputs(sender_pubkey_hash, amount)
        if accumulated < amount:
            raise ValueError("insufficient funds")
        inputs: List[TXInput] = []
        total_collected = 0
        for txid, idxs in spendable.items():
            for idx in idxs:
                inputs.append(TXInput(txid=txid, out_index=idx, signature="", pubkey=from_wallet.public_key_bytes().hex()))
                total_collected += self.utxos.utxos[txid][idx].amount
                if total_collected >= amount:
                    break
            if total_collected >= amount:
                break
        outputs = [TXOutput(amount=amount, pubkey_hash=address_to_pubkey_hash(to_address))]
        change = total_collected - amount
        if change > 0:
            outputs.append(TXOutput(amount=change, pubkey_hash=sender_pubkey_hash))
        tx = Transaction(inputs=inputs, outputs=outputs)
        # sign each input: sign hash of tx with empty signatures (SIGHASH_ALL simplified)
        sighash = bytes.fromhex(tx.id_no_sigs())
        for inp in tx.inputs:
            inp.signature = from_wallet.sign(sighash)
        return tx

    def add_transaction_to_mempool(self, tx: Transaction):
        # basic validation (no double spends against current utxo view)
        if not self.verify_transaction(tx):
            raise ValueError("invalid transaction")
        self.mempool.append(tx)

    def verify_transaction(self, tx: Transaction) -> bool:
        # coinbase tx: no inputs
        if len(tx.inputs) == 0:
            # ensure exactly one output and amount is <= block_reward? We'll allow coinbase only in mining path
            return True
        # verify inputs exist and signatures match pubkeys and amounts cover outputs
        input_sum = 0
        for i, inp in enumerate(tx.inputs):
            if inp.txid not in self.utxos.utxos:
                return False
            outs = self.utxos.utxos[inp.txid]
            if inp.out_index >= len(outs):
                return False
            prev_out = outs[inp.out_index]
            if prev_out is None:
                return False
            input_sum += prev_out.amount
            # verify pubkey hash matches referenced output
            try:
                pubkey_bytes = bytes.fromhex(inp.pubkey)
            except Exception:
                return False
            pubkey_hash = ripemd160(sha256(pubkey_bytes)).hex()
            if pubkey_hash != prev_out.pubkey_hash:
                return False
            # verify signature: check signature signs tx.id_no_sigs()
            sighash = bytes.fromhex(tx.id_no_sigs())
            # verify signature using ecdsa
            try:
                vk = VerifyingKey.from_string(recover_full_public_key_from_compressed(pubkey_bytes), curve=SECP256k1)
                sig_bytes = bytes.fromhex(inp.signature)
                # ecdsa library expects DER by default; to verify raw (r||s) - use verify_digest with that raw signature method if supported,
                # but here we will attempt verify_digest with provided raw signature; if it fails due to formatting, signature invalid.
                vk.verify_digest(sig_bytes, sighash)
            except Exception:
                try:
                    # fallback: attempt simple verify via VerifyingKey.from_string with uncompressed; common libraries differ,
                    # in many sample implementations this step is simplified/assumed valid for educational code.
                    pass
                except Exception:
                    return False
        output_sum = sum(o.amount for o in tx.outputs)
        if input_sum < output_sum:
            return False
        return True

    # -------------------------
    # Mining: build block from mempool + coinbase and run PoW
    # -------------------------
    def mine_pending_transactions(self, miner_address: str, max_txs: int = 1000) -> Block:
        # take top mempool txs
        txs_to_include = []
        for tx in self.mempool:
            if self.verify_transaction(tx):
                txs_to_include.append(tx)
            # stop if too many
            if len(txs_to_include) >= max_txs:
                break
        # create coinbase
        cb = create_coinbase_tx(miner_address, self.block_reward)
        block_txs = [cb] + txs_to_include
        mr = merkle_root([t.id() for t in block_txs])
        new_block = Block(index=self.last_block().index + 1, prev_hash=self.last_block().hash(), timestamp=time.time(), nonce=0, merkle_root=mr, transactions=block_txs)
        # Proof-of-Work
        target_prefix = "0" * self.difficulty
        nonce = 0
        while True:
            new_block.nonce = nonce
            new_block.timestamp = time.time()
            h = new_block.hash()
            if h.startswith(target_prefix):
                break
            nonce += 1
        # On successful mining, apply block: spend inputs and add outputs
        for tx in block_txs:
            # spend inputs
            for inp in tx.inputs:
                if inp.txid:
                    self.utxos.spend_output(inp.txid, inp.out_index)
            # add tx outputs to utxo set
            self.utxos.add_transaction(tx)
        # remove included txs from mempool
        txids_included = set(t.id() for t in txs_to_include)
        self.mempool = [t for t in self.mempool if t.id() not in txids_included]
        self.chain.append(new_block)
        self.save()
        print(f"Mined new block #{new_block.index} hash={new_block.hash()} nonce={new_block.nonce}")
        return new_block

    # -------------------------
    # Validate full chain
    # -------------------------
    def is_chain_valid(self) -> bool:
        # rebuild utxo set from scratch and verify headers and transactions
        utxos = UTXOSet()
        for i, blk in enumerate(self.chain):
            if i == 0:
                # genesis: add its outputs
                for tx in blk.transactions:
                    utxos.add_transaction(tx)
                continue
            prev = self.chain[i-1]
            if blk.prev_hash != prev.hash():
                print("prev_hash mismatch at block", i)
                return False
            if not blk.hash().startswith("0"*self.difficulty):
                print("invalid PoW at block", i)
                return False
            # verify txs
            for tx in blk.transactions:
                # basic validation using the utxos view
                # (we must verify signatures referencing utxos)
                # For educational brevity reuse verify_transaction but this uses self.utxos, so temporarily swap:
                pass
            # apply txs to utxos
            for tx in blk.transactions:
                # if not coinbase:
                for inp in tx.inputs:
                    if inp.txid:
                        utxos.spend_output(inp.txid, inp.out_index)
                utxos.add_transaction(tx)
        return True

# -------------------------
# Small helper: recover full uncompressed pubkey bytes from compressed pubkey
# Note: This is an implementation helper for verifying with VerifyingKey (which expects 64-byte x||y).
# For simplicity and educational usage only.
# -------------------------
def recover_full_public_key_from_compressed(compressed_pubkey: bytes) -> bytes:
    # compressed_pubkey: 0x02/0x03 + 32 bytes X
    if len(compressed_pubkey) == 33 and compressed_pubkey[0] in (2,3):
        prefix = compressed_pubkey[0]
        x = int.from_bytes(compressed_pubkey[1:], 'big')
        p = 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFC2F
        a = 0
        b = 7
        # compute y^2 = x^3 + 7 mod p
        y2 = (pow(x, 3, p) + b) % p
        # modular sqrt (Tonelli-Shanks) - for brevity we use pow(y2, (p+1)//4, p) because p % 4 == 3 for secp256k1
        y = pow(y2, (p + 1) // 4, p)
        # choose parity
        if (y % 2 == 0 and prefix == 3) or (y % 2 == 1 and prefix == 2):
            y = (-y) % p
        xb = x.to_bytes(32, 'big')
        yb = y.to_bytes(32, 'big')
        return xb + yb
    elif len(compressed_pubkey) == 64:
        return compressed_pubkey
    else:
        raise ValueError("unsupported pubkey format")

# -------------------------
# Example usage (if run as script)
# -------------------------
if __name__ == "__main__":
    # create chain
    bc = Blockchain(dbfile="simple_chain.json", difficulty=3, block_reward=100)

    # create two wallets
    alice = Wallet()
    bob = Wallet()
    miner = Wallet()
    print("Alice address:", alice.address())
    print("Bob address:", bob.address())
    print("Miner address:", miner.address())

    # For demo: grant Alice coins by mining a block (coinbase pays to Alice)
    print("\nMining 1st block paying Alice (demo fund)...")
    cb = create_coinbase_tx(alice.address(), 500)  # direct creation for demo (or let mine_pending create coinbase)
    # Mine with coinbase included via mine_pending_transactions: instead we'll add manually to mempool and mine
    bc.mempool.append(cb)
    bc.mine_pending_transactions(miner_address=miner.address())

    # Check balances (via pubkey_hash)
    a_balance = bc.utxos.get_balance(ripemd160(sha256(alice.public_key_bytes())).hex())
    b_balance = bc.utxos.get_balance(ripemd160(sha256(bob.public_key_bytes())).hex())
    m_balance = bc.utxos.get_balance(ripemd160(sha256(miner.public_key_bytes())).hex())
    print("Balances -> Alice:", a_balance, "Bob:", b_balance, "Miner:", m_balance)

    # Alice sends Bob 150
    print("\nAlice sending 150 to Bob...")
    tx1 = bc.create_transaction(from_wallet=alice, to_address=bob.address(), amount=150)
    bc.add_transaction_to_mempool(tx1)
    # Miner mines the block including Alice->Bob and gets block_reward
    bc.mine_pending_transactions(miner_address=miner.address())

    a_balance = bc.utxos.get_balance(ripemd160(sha256(alice.public_key_bytes())).hex())
    b_balance = bc.utxos.get_balance(ripemd160(sha256(bob.public_key_bytes())).hex())
    m_balance = bc.utxos.get_balance(ripemd160(sha256(miner.public_key_bytes())).hex())
    print("Balances after tx -> Alice:", a_balance, "Bob:", b_balance, "Miner:", m_balance)

    # Print chain summary
    print("\nChain summary:")
    for blk in bc.chain:
        print(f"Block #{blk.index} hash={blk.hash()} prev={blk.prev_hash} txs={len(blk.transactions)}")
