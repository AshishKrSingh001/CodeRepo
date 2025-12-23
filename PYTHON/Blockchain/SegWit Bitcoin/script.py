# script.py
# This file defines the Script class for Bitcoin transaction scripts.
# It includes methods for serialization, evaluation, and standard P2PKH scripts.

from util import encode_varient, int_to_little_endian
from op import OP_CODE_FUNCTION

class Script:
    """
    Represents a Bitcoin Script.
    
    Attributes:
        cmds (list): List of commands (integers or bytes) that make up the script.
    """
    
    def __init__(self, cmds=None):
        """
        Initializes a new Script.
        
        Args:
            cmds (list, optional): List of commands. Defaults to empty list.
        """
        self.cmds = cmds if cmds else []

    # -------------------------------
    # Combine two scripts
    # -------------------------------
    def __add__(self, other):
        """
        Combines two Script objects.
        
        Args:
            other (Script): Another Script object to concatenate.
            
        Returns:
            Script: New Script containing commands from both scripts.
        """
        return Script(self.cmds + other.cmds)

    # -------------------------------
    # Serialize the script
    # -------------------------------
    def serialize(self):
        """
        Serializes the script into bytes according to Bitcoin protocol rules.
        
        Returns:
            bytes: Serialized script with proper length prefix.
        """
        result = b''

        for cmd in self.cmds:
            if type(cmd) == int:
                # Single-byte opcode
                result += int_to_little_endian(cmd, 1)
            else:
                # Data to push onto stack
                length = len(cmd)
                if length < 75:
                    result += int_to_little_endian(length, 1)
                elif 75 <= length < 0x100:
                    result += int_to_little_endian(76, 1)
                    result += int_to_little_endian(length, 1)
                elif 0x100 <= length < 520:
                    result += int_to_little_endian(77, 1)
                    result += int_to_little_endian(length, 2)
                else:
                    raise ValueError("Value is too large")
                result += cmd

        # Prefix with total length as varint
        total_length = len(result)
        return encode_varient(total_length) + result

    # -------------------------------
    # Evaluate script
    # -------------------------------
    def evaluate(self, z):
        """
        Evaluates the script for a given message hash `z`.
        
        Args:
            z (int): Hash of the transaction to verify signatures against.
        
        Returns:
            bool: True if evaluation succeeds, False otherwise.
        """
        cmds = self.cmds[:]
        stack = []

        while len(cmds) > 0:
            cmd = cmds.pop(0)

            if type(cmd) == int:
                operation = OP_CODE_FUNCTION[cmd]

                # Special handling for OP_CHECKSIG
                if cmd == 172:  # OP_CHECKSIG
                    if not operation(stack, z):
                        print("Error in Signature Verification")
                        return False
                # Other opcodes
                elif not operation(stack):
                    print("Error in Signature Verification")
                    return False
            else:
                # Push data onto stack
                stack.append(cmd)
        return True

    # -------------------------------
    # Standard P2PKH script
    # -------------------------------
    @classmethod
    def p2pkh_script(cls, h160):
        """
        Creates a standard Pay-to-PubKey-Hash (P2PKH) script.
        
        Args:
            h160 (bytes): Public key hash (RIPEMD160 of SHA256 of public key)
        
        Returns:
            Script: A new Script object representing the P2PKH script.
        """
        # OP_DUP OP_HASH160 <pubKeyHash> OP_EQUALVERIFY OP_CHECKSIG
        return Script([0x76, 0xa9, h160, 0x88, 0xac])
