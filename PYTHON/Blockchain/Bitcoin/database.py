import os
import json

class Base_db:
    def __init__(self):
        self.base_path = 'data'
        self.file_path = '/'.join((self.base_path, self.filename))

    def read(self):
        if not os.path.exists(self.file_path):
            print(f"File {self.file_path} not available")
            return False

        with open(self.file_path) as file:
            raw = file.readline()
        
        if len(raw) > 0:
            data = json.loads(raw)
        else:
            data = []
        return data

    def write(self, item):
        data = self.read()
        if data:
            data = data + item
        else:
            data = item
        with open(self.file_path, 'w+') as file:
            file.write(json.dumps(data))

class Blockchain_db(Base_db):
    def __init__(self):
        self.filename = 'blockchain'
        super().__init__()

    def last_block(self):
        data = self.read()

        if data:
            return data[-1] 
        
class Account_db(Base_db):
    def __init__(self):
        self.filename = "account"
        super().__init__()
