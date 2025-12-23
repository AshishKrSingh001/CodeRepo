"""
This module defines the basic Bitcoin Script operation functions.
Each function manipulates a stack and implements specific Bitcoin script opcodes.
"""

from util import hash160
from ECC import Sha256Point, Signature

# -------------------------------
# Stack operation functions
# -------------------------------

def op_dup(stack):
    """
    Duplicates the top element of the stack.
    
    Args:
        stack (list): The stack to operate on.
    
    Returns:
        bool: True if successful, False if stack is empty.
    """
    if len(stack) < 1:
        return False
    stack.append(stack[-1])
    return True


def op_hash160(stack):
    """
    Pops the top element from the stack, hashes it with SHA256 then RIPEMD160,
    and pushes the result back on the stack.
    
    Args:
        stack (list): The stack to operate on.
    
    Returns:
        bool: True if successful, False if stack is empty.
    """
    if len(stack) < 1:
        return False
    element = stack.pop()
    h160 = hash160(element)
    stack.append(h160)
    return True


def op_equal(stack):
    """
    Pops the top two elements from the stack and pushes 1 if they are equal, 0 otherwise.
    
    Args:
        stack (list): The stack to operate on.
    
    Returns:
        bool: True if operation successful, False if not enough elements.
    """
    if len(stack) < 2:
        return False

    element1 = stack.pop()
    element2 = stack.pop()

    if element1 == element2:
        stack.append(1)
    else:
        stack.append(0)

    return True


def op_verify(stack):
    """
    Pops the top element from the stack and checks if it is non-zero.
    
    Args:
        stack (list): The stack to operate on.
    
    Returns:
        bool: True if element is non-zero, False otherwise.
    """
    if len(stack) < 1:
        return False

    element = stack.pop()
    return element != 0


def op_equalverify(stack):
    """
    Combines OP_EQUAL and OP_VERIFY.
    
    Args:
        stack (list): The stack to operate on.
    
    Returns:
        bool: True if the top two elements are equal and verified, False otherwise.
    """
    return op_equal(stack) and op_verify(stack)


def op_checksig(stack, z):
    """
    Checks the signature against the public key for a given transaction hash.
    
    Args:
        stack (list): The stack containing signature and public key.
        z (int): The transaction hash to verify against.
    
    Returns:
        bool: True if signature is valid, False otherwise.
    """
    if len(stack) < 2:
        return False

    # Pop public key and signature from stack
    sec_pubkey = stack.pop()
    der_signature = stack.pop()[:-1]  # remove SIGH_HASH byte

    try:
        point = Sha256Point.parse(sec_pubkey)
        sig = Signature.parse(der_signature)
    except Exception:
        return False

    if point.verify(z, sig):
        stack.append(1)
        return True
    else:
        stack.append(0)
        return False


# -------------------------------
# Opcode to function mapping
# -------------------------------
OP_CODE_FUNCTION = {
    118: op_dup,         # OP_DUP
    136: op_equalverify, # OP_EQUALVERIFY
    169: op_hash160,     # OP_HASH160
    172: op_checksig     # OP_CHECKSIG
}
