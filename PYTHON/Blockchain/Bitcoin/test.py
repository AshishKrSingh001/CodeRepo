from math import log


def int_to_little_endian(n, length):
    return n.to_bytes(length, 'little')

def int_to_big_endian(n, length):
    return n.to_bytes(length, 'big')

def little_endian_to_int(b):
    return int.from_bytes(b, 'little')

def big_endian_to_int(b):
    return int.from_bytes(b, 'big')

def bytes_needed(n):
    if n==0:
        return 1
    else:
        return int(log(n, 256)) + 1
    
num = 16777216
bytes_required = bytes_needed(num)
little_endian = int_to_little_endian(num, bytes_required)
big_endian = int_to_big_endian(num, bytes_required)
print(f"num = {num}")
print(f"bytes_needd = {bytes_required}")
print(f"little_endian = {little_endian}")
print(f"big_endian = {big_endian}")
print(f"big_endian to num = {big_endian_to_int(big_endian)}")
print(f"little_endian to num = {little_endian_to_int(little_endian)}")
