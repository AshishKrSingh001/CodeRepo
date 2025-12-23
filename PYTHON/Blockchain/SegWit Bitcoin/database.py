"""
This module provides a simple JSON-based database system for the blockchain project.
It supports reading and writing to files in a structured way.
"""

import os
import json

# -------------------------------
# Base database class
# -------------------------------

class Base_DB:
    """
    Base class for file-based JSON storage.
    Handles reading from and writing to a JSON file in a specific folder.
    """

    def __init__(self):
        # Folder where all JSON files will be stored
        self.base_path = "data"
        os.makedirs(self.base_path, exist_ok=True)
        
        # Full path to the specific database file
        self.file_path = os.path.join(self.base_path, self.filename)

    def read(self):
        """
        Read the content of the database file.
        Returns a list of items. If the file does not exist or is corrupted, returns an empty list.
        """
        if not os.path.exists(self.file_path):
            return []

        try:
            with open(self.file_path, "r") as f:
                return json.load(f)
        except json.JSONDecodeError:
            print(f"⚠️ Corrupted DB: {self.file_path}")
            return []

    def write(self, item):
        """
        Append data to the JSON database.
        Supports adding a single item or a list of items.
        
        Args:
            item (dict or list): The item(s) to append to the database.
        
        Raises:
            TypeError: If the current database content is not a list.
        """
        data = self.read()

        if not isinstance(data, list):
            raise TypeError("DB must store a list")

        if isinstance(item, list):
            data.extend(item)
        else:
            data.append(item)

        with open(self.file_path, "w") as f:
            json.dump(data, f, indent=4)

# -------------------------------
# Blockchain database class
# -------------------------------

class Blockchain_DB(Base_DB):
    """
    Database for storing blockchain blocks.
    Each block is stored as a dictionary in a JSON list.
    """

    def __init__(self):
        self.filename = "blockchain.json"
        super().__init__()

    def lastblock(self):
        """
        Returns the last block in the blockchain, or None if the blockchain is empty.
        """
        data = self.read()
        return data[-1] if data else None

    def get_block(self, block_height):
        """
        Retrieve a specific block by its height.
        
        Args:
            block_height (int): Height/index of the block in the blockchain.
        
        Returns:
            dict or None: The block dictionary if found, else None.
        """
        for block in self.read():
            if block["height"] == block_height:
                return block
        return None

# -------------------------------
# Account database class
# -------------------------------

class Account_DB(Base_DB):
    """
    Database for storing account information such as private keys and public addresses.
    Each account is stored as a dictionary in a JSON list.
    """

    def __init__(self):
        self.filename = "account.json"
        super().__init__()
