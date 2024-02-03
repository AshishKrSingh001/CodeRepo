def sum_of_digit(num):
    sum = 0
    while(num > 0):
        d = num % 10
        sum = sum + d
        num = num // 10
    return sum
    
def rev_of_digit(num):
    rev = 0
    while(num > 0):
        d = num % 10
        rev = (rev*10) + d
        num = num // 10
    return rev
        
def count_of_digit(num):
    com = 0
    if num==0:
        return 1
    while(num > 0):
        d = num % 10
        com += 1
        num = num // 10
    return com