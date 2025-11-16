import a22_NumberModule as Number

num = int(input("Enter a number: "))
print("Sum of digit ",num," is: ",Number.sum_of_digit(num))
print("Reverse of digit",num," is: ",Number.rev_of_digit(num))
print("Count of digit",num," is: ",Number.count_of_digit(num))

print(dir(Number))