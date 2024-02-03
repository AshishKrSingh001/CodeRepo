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
    return com