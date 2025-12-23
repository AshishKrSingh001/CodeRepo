# util.py
# This file contains utility functions used in Bitcoin-related operations,
# including hashing, encoding, and Merkle tree computations.

from hashlib import sha256
from Crypto.Hash import RIPEMD160
from math import log
import json

# -------------------------------
# Base58 Alphabet used in Bitcoin
# -------------------------------
BASE58_ALPHABET = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz"


# -------------------------------
# Hash Functions
# -------------------------------

def hash256(s: bytes) -> bytes:
    """
    Performs SHA256(SHA256(s)) hashing (double SHA256).
    Used for checksums in Bitcoin addresses and blocks.
    
    Args:
        s (bytes): Input byte string.
        
    Returns:
        bytes: 32-byte hash result.
    """
    return sha256(sha256(s).digest()).digest()


def hash160(s: bytes) -> bytes:
    """
    Performs HASH160 which is RIPEMD160(SHA256(s)).
    Used for Bitcoin addresses.
    
    Args:
        s (bytes): Input byte string.
        
    Returns:
        bytes: 20-byte hash result.
    """
    return RIPEMD160.new(sha256(s).digest()).digest()


# -------------------------------
# Byte / Integer Conversion
# -------------------------------

def bytes_needed(num: int) -> int:
    """
    Calculates the minimum number of bytes needed to represent an integer.
    
    Args:
        num (int): Input integer.
        
    Returns:
        int: Number of bytes required.
    """
    if num == 0:
        return 1
    return int(log(num, 256)) + 1


def int_to_little_endian(num: int, length: int) -> bytes:
    """
    Converts an integer to little-endian byte format.
    
    Args:
        num (int): Input integer.
        length (int): Length of bytes output.
        
    Returns:
        bytes: Little-endian byte representation.
    """
    return num.to_bytes(length, 'little')


def little_endian_to_int(b: bytes) -> int:
    """
    Converts little-endian bytes to integer.
    
    Args:
        b (bytes): Little-endian bytes.
        
    Returns:
        int: Integer representation.
    """
    return int.from_bytes(b, 'little')


# -------------------------------
# Base58 Encoding / Decoding
# -------------------------------

def encode_base58(b: bytes) -> str:
    """
    Encodes bytes into a Base58 string with Bitcoin alphabet.
    
    Args:
        b (bytes): Input bytes.
        
    Returns:
        str: Base58 encoded string.
    """
    count = 0
    for c in b:
        if c == 0:
            count += 1
        else:
            break
    prefix = '1' * count

    num = int.from_bytes(b, byteorder='big')
    result = ''
    while num > 0:
        num, mod = divmod(num, 58)
        result = BASE58_ALPHABET[mod] + result

    return prefix + result


def decode_base58(s: str) -> bytes:
    """
    Decodes a Base58 string to bytes and verifies checksum.
    
    Args:
        s (str): Base58 encoded string.
        
    Returns:
        bytes: Decoded 20-byte hash (public key hash).
        
    Raises:
        ValueError: If checksum is invalid.
    """
    num = 0
    for c in s:
        num *= 58
        num += BASE58_ALPHABET.index(c)

    combined = num.to_bytes(25, byteorder="big")
    checksum = combined[-4:]

    if hash256(combined[:-4])[:4] != checksum:
        raise ValueError(f"bad Address {checksum} {hash256(combined[:-4][:4])}")

    return combined[1:-4]


# -------------------------------
# Variable Integer Encoding
# -------------------------------

def encode_varient(i: int) -> bytes:
    """
    Encodes an integer using Bitcoin variable length integer format.
    
    Args:
        i (int): Integer to encode.
        
    Returns:
        bytes: Encoded bytes.
        
    Raises:
        ValueError: If the value is too large.
    """
    if i < 0xfd:
        return bytes([i])
    elif i < 0x10000:
        return b'\xfd' + int_to_little_endian(i, 2)
    elif i < 0x100000000:
        return b'\xfe' + int_to_little_endian(i, 4)
    elif i < 0x10000000000000000:
        return b'\xff' + int_to_little_endian(i, 8)
    else:
        raise ValueError(f"Too large value {i}")


# -------------------------------
# Merkle Tree Functions
# -------------------------------

def merkle_parent_level(hashes: list[bytes]) -> list[bytes]:
    """
    Computes the parent level of a list of hashes.
    If the number of hashes is odd, duplicates the last hash.
    
    Args:
        hashes (list of bytes): Current level of hashes.
        
    Returns:
        list of bytes: Parent level hashes.
    """
    if len(hashes) % 2 == 1:
        hashes.append(hashes[-1])

    parent_level = []
    for i in range(0, len(hashes), 2):
        parent = hash256(hashes[i] + hashes[i+1])
        parent_level.append(parent)

    return parent_level


def merkle_root(hashes: list[bytes]) -> bytes:
    """
    Computes the Merkle root from a list of transaction hashes.
    
    Args:
        hashes (list of bytes): List of transaction hashes.
        
    Returns:
        bytes: Merkle root.
    """
    current_level = hashes
    while len(current_level) > 1:
        current_level = merkle_parent_level(current_level)

    return current_level[0]


# -------------------------------
# Target / Bits Conversion
# -------------------------------

def target_to_bits(target: int) -> bytes:
    """
    Converts a mining target into compact bits representation (used in block headers).
    
    Args:
        target (int): Mining target.
        
    Returns:
        bytes: Compact bits representation.
    """
    raw_bytes = target.to_bytes(32, 'big')
    raw_bytes = raw_bytes.lstrip(b'\x00')
    if raw_bytes[0] > 0x7f:
        exponent = len(raw_bytes) + 1
        coefficient = b'\x00' + raw_bytes[:2]
    else:
        exponent = len(raw_bytes)
        coefficient = b'\x00' + raw_bytes[:3]
    new_bits = coefficient[::-1] + bytes([exponent])
    return new_bits


