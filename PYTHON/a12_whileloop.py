num = int(input("Enter any Number: "))
n = num
sum = 0
while(num > 0):
    d = num % 10
    sum = sum + d
    num = num // 10
print("Sum of digit of ",n," is : ",sum)