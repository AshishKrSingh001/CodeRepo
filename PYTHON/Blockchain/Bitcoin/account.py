from EllepticCurve.EllepticCurve import Sha256Point
import secrets
from util import hash160, hash256, encode_base58
from database import Account_db

class Account:
    def create_keys(self):
        """Secp256k1 Curve Generator Points"""
        Gx = 0x79BE667EF9DCBBAC55A06295CE870B07029BFCDB2DCE28D959F2815B16F81798
        Gy = 0x483ADA7726A3C4655DA4FBFC0E1108A8FD17B448A68554199C47D08FFB10D4B8

        G = Sha256Point(Gx, Gy)

        self.private_key = secrets.randbits(256)
        uncompressed_public_key = self.private_key * G

        x_point = uncompressed_public_key.x
        y_point = uncompressed_public_key.y

        if y_point.num % 2 == 0:
            compressed_key = b'\x02' + x_point.num.to_bytes(32, 'big')
        
        else:
            compressed_key = b'\x03' + x_point.num.to_bytes(32, 'big')

        hsh160 = hash160(compressed_key)
        """Prefix for Mainnet"""
        main_prefix = b'\x00'
        new_address = main_prefix + hsh160

        """Checksum"""
        checksum = hash256(new_address)[:4]

        new_address = new_address + checksum

        self.public_address = encode_base58(new_address)

        print(f"Private Key {self.private_key}")
        print(f"Public Key {self.public_address}")
        print(f"Xpoint {x_point} \n Ypoint {y_point}")

if __name__ == "__main__":
    acct = Account()
    acct.create_keys()
    Account_db().write([acct.__dict__])