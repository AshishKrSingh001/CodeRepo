class BankAccount:
    def __init__(self, acc_no, name, balance=0):
        self.acc_no = acc_no
        self.name = name
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount

    def withdraw(self, amount):
        if amount <= self.balance:
            self.balance -= amount
        else:
            print("Insufficient funds")

    def display(self):
        print(f"Account: {self.acc_no}, Name: {self.name}, Balance: {self.balance}")

acc = BankAccount(101, "Ashish", 5000)
acc.deposit(2000)
acc.withdraw(1000)
acc.display()
