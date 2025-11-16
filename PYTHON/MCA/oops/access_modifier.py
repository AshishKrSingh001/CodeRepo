class Account():
    def __init__(self, owner, balance):
        self.owner = owner
        self.balance = balance
        self.__pin = 1234

    def deposite(self, amount):
        self.balance+= amount

    def withdraw(self, amount):
        self.balance -= amount

    def get_balance(self):
        return self.balance
    
s = Account("Ashish", 1000)
s.deposite(100)
print(s.get_balance())
print(s.balance)
print(s.__pin)
