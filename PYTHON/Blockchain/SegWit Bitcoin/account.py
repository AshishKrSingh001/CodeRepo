"""
=====================================================================
Bitcoin Account Generator (Educational / Beginner-Friendly)
=====================================================================

This script creates a Bitcoin-like account with:

1. Private key (256-bit integer)
2. Compressed public key
3. Public address (Base58Check encoded)

It also stores account information in a JSON-based database (`Account_DB`) 
for future reference.

Dependencies:
---------------
- Python 3.x
- ECC.py (your existing elliptic curve module)
- util.py (hash160, hash256, encode_base58)
- database.py (Account_DB class)

Author: Educational Example
=====================================================================
"""

import secrets  # for generating secure random numbers
from ECC import PrivateKey  # custom ECC library you have
from util import hash160, hash256, encode_base58
from database import Account_DB


class Account:
    """
    Represents a Bitcoin-like account with private key, public key, and address.
    """

    def __init__(self):
        # Initialize variables
        self.private_key = None
        self.public_address = None

    def create_keys(self):
        """
        Generate a new private key, derive the public key, 
        and create a Bitcoin-like address.
        """

        # ------------------------------------------
        # Step 1: Generate a secure 256-bit private key
        # ------------------------------------------
        self.private_key = secrets.randbits(256)

        # ------------------------------------------
        # Step 2: Create a PrivateKey object
        # The ECC library computes public key = private_key * G
        # ------------------------------------------
        private_key_obj = PrivateKey(secret=self.private_key)

        # ------------------------------------------
        # Step 3: Get compressed public key
        # Compressed form reduces size from 65 to 33 bytes
        # ------------------------------------------
        compressed_pubkey = private_key_obj.point.sec(compressed=True)

        # ------------------------------------------
        # Step 4: Hash the public key
        # Bitcoin addresses use RIPEMD160(SHA256(pubkey))
        # ------------------------------------------
        pub_key_hash = hash160(compressed_pubkey)

        # ------------------------------------------
        # Step 5: Add network prefix (mainnet = 0x00)
        # ------------------------------------------
        prefix = b'\x00'
        versioned_payload = prefix + pub_key_hash

        # ------------------------------------------
        # Step 6: Calculate checksum (double SHA256)
        # ------------------------------------------
        check_sum = hash256(versioned_payload)[:4]

        # ------------------------------------------
        # Step 7: Encode to Base58Check
        # This is the final Bitcoin address
        # ------------------------------------------
        self.public_address = encode_base58(versioned_payload + check_sum)

        # ------------------------------------------
        # Step 8: Display results
        # ------------------------------------------
        print("✅ Account Created Successfully!")
        print(f"Private Key (decimal): {self.private_key}")
        print(f"Public Address (Base58Check): {self.public_address}")


# ========================================================
# ACCOUNT INITIALIZATION
# ========================================================
def ensure_account():
    """
    Ensure at least one account exists in Account_DB.
    If empty, create a new one and save it.
    Returns the first account.
    """
    db = Account_DB()
    existing_accounts = db.read()  # Read saved accounts

    if not existing_accounts:  # No account exists
        account = Account()
        account.create_keys()  # Generates private/public key pair
        db.write([account.__dict__])  # Save as a list
        print(f"✅ New account created and saved: {account.public_address}")
        return account.__dict__

    # Return the first existing account
    first_account = existing_accounts[0]
    print(f"ℹ️ Using existing account: {first_account['public_address']}")
    return first_account
