from flask import Flask, render_template, request
from sendBTC import SendBTC
from transaction import Tx

# Initialize Flask app
app = Flask(__name__)

# Global variables for UTXOs and MEMPOOL
UTXOS = {}
MEMPOOL = {}

# -------------------------------
# Wallet route
# -------------------------------
@app.route("/", methods=["GET", "POST"])
def wallet():
    """
    Handles the wallet page. Supports GET (render page) and POST (create transaction).
    """
    message = ""  # Message to display on wallet.html

    if request.method == "POST":
        # Fetch form data
        FromAddress = request.form.get("fromAddress")
        ToAddress = request.form.get("toAddress")
        Amount = request.form.get("Amount", type=int)

        # Create a SendBTC object to prepare the transaction
        sendCoin = SendBTC(FromAddress, ToAddress, Amount, UTXOS)

        # Prepare the transaction
        TxObj = sendCoin.prepare_transaction()

        # ScriptPubKey of sender address
        scriptPubKey = sendCoin.script_pubkey(FromAddress)

        # Assume verification succeeds
        verified = True

        if not TxObj:
            message = "Invalid Transaction"

        # Verify each input if transaction is valid
        if isinstance(TxObj, Tx):
            for index, tx_in in enumerate(TxObj.tx_ins):
                if not TxObj.verify_input(index, scriptPubKey):
                    verified = False

            if verified:
                # Add verified transaction to MEMPOOL
                MEMPOOL[TxObj.tx_id] = TxObj
                message = "Transaction added in Memory Pool"

        # Debug output
        print("TxObj:", TxObj)
        print("Verified:", verified)
        print("MEMPOOL SIZE:", len(MEMPOOL))

    # Render wallet page with message
    return render_template("wallet.html", message=message)

# -------------------------------
# Main function to run Flask
# -------------------------------
def main(utxos, mempool):
    """
    Starts the Flask server for wallet interaction.

    Args:
        utxos (dict): Dictionary of unspent transaction outputs.
        mempool (dict): Dictionary of transactions in memory pool.
    """
    global UTXOS, MEMPOOL
    UTXOS = utxos
    MEMPOOL = mempool
    app.run()
