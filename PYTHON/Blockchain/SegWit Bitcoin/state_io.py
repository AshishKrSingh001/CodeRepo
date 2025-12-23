# database.py
# This file handles saving and loading the state of UTXOs and mempool transactions.

import json
import os
from transaction import Tx

# File paths for persistent storage
UTXO_FILE = "data/utxos.json"
MEMPOOL_FILE = "data/mempool.json"


# -------------------------------
# Save State
# -------------------------------
def save_state(utxos, mempool):
    """
    Saves the current state of UTXOs and mempool to JSON files.
    
    Parameters:
        utxos (dict): Dictionary of UTXO transactions {txid: Tx object}.
        mempool (dict): Dictionary of pending transactions {txid: Tx object}.
    """
    # Ensure the data directory exists
    os.makedirs("data", exist_ok=True)

    # Convert UTXO transactions to dictionary for JSON serialization
    utxo_json = {txid: tx.to_dict() for txid, tx in utxos.items()}

    # Convert mempool transactions to dictionary for JSON serialization
    mempool_json = {txid: tx.to_dict() for txid, tx in mempool.items()}

    # Write UTXOs to file
    with open(UTXO_FILE, "w") as f:
        json.dump(utxo_json, f, indent=4)

    # Write mempool to file
    with open(MEMPOOL_FILE, "w") as f:
        json.dump(mempool_json, f, indent=4)


# -------------------------------
# Load State
# -------------------------------
def load_state():
    """
    Loads UTXOs and mempool from JSON files.
    Returns:
        tuple: (utxos, mempool)
            utxos (dict): Dictionary of UTXO transactions {txid: Tx object}.
            mempool (dict): Dictionary of pending transactions {txid: Tx object}.
    """
    utxos = {}
    mempool = {}

    # Load UTXOs
    try:
        if os.path.exists(UTXO_FILE) and os.path.getsize(UTXO_FILE) > 0:
            with open(UTXO_FILE, "r") as f:
                data = json.load(f)
                for txid, tx_dict in data.items():
                    # Convert dictionary back to Tx object
                    utxos[txid] = Tx.from_dict(tx_dict)
    except Exception as e:
        print("⚠️ Failed to load UTXOs, starting fresh:", e)

    # Load mempool
    try:
        if os.path.exists(MEMPOOL_FILE) and os.path.getsize(MEMPOOL_FILE) > 0:
            with open(MEMPOOL_FILE, "r") as f:
                data = json.load(f)
                for txid, tx_dict in data.items():
                    # Convert dictionary back to Tx object
                    mempool[txid] = Tx.from_dict(tx_dict)
    except Exception as e:
        print("⚠️ Failed to load mempool, starting fresh:", e)

    return utxos, mempool
