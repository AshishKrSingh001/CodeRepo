"""
ECDSA Implementation for Bitcoin-like Cryptography
-------------------------------------------------

This module provides:
1. Signature class for DER encoding/decoding.
2. Public key wrapper (Sha256Point) for verification and SEC encoding.
3. Private key wrapper (PrivateKey) for signing messages.

Key improvements:
- Added type checks and value validation for private keys.
- Improved error handling for verification and signing.
- Detailed comments for beginners.
"""

import hashlib
from ecdsa import SigningKey, VerifyingKey, SECP256k1, util

# -------------------------------
# Signature class
# -------------------------------
class Signature:
    """
    Represents an ECDSA signature (r, s).
    Can encode to DER format or parse from DER bytes.
    """
    def __init__(self, r: int, s: int):
        self.r = r
        self.s = s

    def der(self) -> bytes:
        """
        Return DER-encoded signature.
        DER format is commonly used in Bitcoin transactions.
        """
        return util.sigencode_der(self.r, self.s, None)

    @classmethod
    def parse(cls, der_bytes: bytes):
        """
        Parse DER-encoded bytes into Signature object.
        """
        r, s = util.sigdecode_der(der_bytes, None)
        return cls(r, s)


# -------------------------------
# Public Key Point
# -------------------------------
class Sha256Point:
    """
    Wrapper for ECDSA VerifyingKey (public key point).
    Provides methods to serialize (SEC format) and verify signatures.
    """
    def __init__(self, verifying_key: VerifyingKey):
        self.vk = verifying_key

    def sec(self, compressed: bool = True) -> bytes:
        """
        Serialize the public key in SEC format.
        Compressed = 33 bytes, Uncompressed = 65 bytes.
        """
        return self.vk.to_string("compressed" if compressed else "uncompressed")

    def verify(self, z: int, sig: Signature) -> bool:
        """
        Verify an ECDSA signature for a given integer hash z.
        Returns True if signature is valid, False otherwise.
        """
        try:
            return self.vk.verify_digest(
                sig.der(),
                z.to_bytes(32, "big"),
                sigdecode=util.sigdecode_der
            )
        except Exception:
            return False

    @classmethod
    def parse(cls, sec_bytes: bytes):
        """
        Parse SEC-encoded bytes into a Sha256Point object.
        """
        vk = VerifyingKey.from_string(sec_bytes, curve=SECP256k1)
        return cls(vk)


# -------------------------------
# Private Key
# -------------------------------
class PrivateKey:
    """
    Wrapper for ECDSA private key.
    Handles key validation, signing, and provides public key access.
    """
    def __init__(self, secret: int):
        """
        Initialize a private key.
        Checks:
        - secret is not None
        - secret is an integer
        - secret is in valid SECP256k1 range (1 <= secret < curve order)
        """
        if secret is None:
            raise ValueError("Private key secret cannot be None")
        if not isinstance(secret, int):
            raise TypeError(f"Private key secret must be int, got {type(secret)}")
        if secret <= 0 or secret >= SECP256k1.order:
            raise ValueError("Private key secret out of valid range")

        self.secret = secret
        self.sk = SigningKey.from_secret_exponent(secret, curve=SECP256k1)
        self.point = Sha256Point(self.sk.get_verifying_key())

    def sign(self, z: int) -> Signature:
        """
        Sign an integer message hash z with the private key.
        Returns a Signature object.
        """
        der_bytes = self.sk.sign_digest(
            z.to_bytes(32, "big"),
            sigencode=util.sigencode_der
        )
        r, s = util.sigdecode_der(der_bytes, None)
        return Signature(r, s)
