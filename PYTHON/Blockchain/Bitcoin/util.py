from hashlib import sha256
from Crypto.Hash import RIPEMD160
import hashlib
from math import log
from EllepticCurve.EllepticCurve import BASE58_ALPHABET


def hash256(s):
    """Two rounds of SHA256"""
    return hashlib.sha256(hashlib.sha256(s).digest()).digest()

def hash160(s):
    return RIPEMD160.new(sha256(s).digest()).digest()

def bytes_needed(n):
    if n == 0:
        return 1
    return int(log(n, 256)) + 1

def int_to_little_endian(n, length):
    """Int_to_little_endian takes an integer and return to little endian byte sequence of length"""
    return n.to_bytes(length, 'little')

def little_endian_to_int(b):
    """Takes a byte sequence and returns an integer"""
    return int.from_bytes(b, 'little')

def encode_base58(b):
    count = 0
    for i in b:
        if i == 0:
            count += 1
        
    prefix = '1' * count

    num = int.from_bytes(b, 'big')
    result = ""
    while num > 0:
        num, rem = divmod(num, 58)
        result = BASE58_ALPHABET[rem] + result

    result = prefix + result
    return result
    


def decode_base58(s):
    num = 0

    for c in s:
        num *= 58
        num += BASE58_ALPHABET.index(c)

    combined = num.to_bytes(25, byteorder='big')
    checksum = combined[-4:]

    if hash256(combined[:-4])[:4] != checksum:
        raise ValueError(f'Bad Address {checksum} {hash256(combined[:-4][:4])}')
    
    return combined[1:-4]

def encode_varint(i):
    """encodes an integer as a variant"""
    if i < 0xFD:
        return bytes([i])
    elif i < 0x10000:
        return b"\xfd" + int_to_little_endian(i, 2)
    elif i < 0x100000000:
        return b"\xfe" + int_to_little_endian(i, 4)
    elif i < 0x10000000000000000:
        return b"\xff" + int_to_little_endian(i, 8)
    else:
        raise ValueError("integer too large: {}".format(i))