  class Number:
    def __init__(self,n):
        self.n = n
    def sum_of_digit(self):
        sum = 0
        num = self.n
        while(num > 0):
            d = num % 10
            sum = sum + d
            num = num // 10
        return sum
    
    def rev_of_digit(self):
        rev = 0
        num = self.n
        while(num > 0):
            d = num % 10
            rev = (rev*10) + d
            num = num // 10
        return rev
        
    def count_of_digit(self):
        com = 0
        num = self.n
        while(num > 0):
            d = num % 10
            com += 1
            num = num // 10
        print("Count of digit of ",num," is : ",com)



num = 123
obj = Number(num)
print("Sum of digit of ",num," is : ",obj.sum_of_digit())
print("Reverse of digit of ",num," is : ",obj.rev_of_digit())
obj.count_of_digit()