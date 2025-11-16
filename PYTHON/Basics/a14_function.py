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
    while(num > 0):
        d = num % 10
        com += 1
        num = num // 10
    print("Count of digit of ",num," is : ",com)
    
def sum(*num):
    n = 0
    for i in num:
        n = n + i
    return n

num = int(input("Enter any Number: "))
print("Sum of digit of ",num," is : ",sum_of_digit(num))
print("Reverse of digit of ",num," is : ",rev_of_digit(num))
count_of_digit(num)

print("Sum: ",sum(10,20,30,40,50,6))

def recursion(num):
    if num == 1:
        return 1
    else:
        return num*(recursion(num-1))

print(recursion(5))
