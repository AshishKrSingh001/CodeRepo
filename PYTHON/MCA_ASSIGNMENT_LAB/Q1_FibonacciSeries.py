# Using for loop
n = int(input("Enter number of terms: "))
a, b = 0, 1
print("Fibonacci Series using for loop:")
for i in range(n):
    print(a, end=" ")
    a, b = b, a + b

# Using while loop
print("\nFibonacci Series using while loop:")
a, b = 0, 1
count = 0
while count < n:
    print(a, end=" ")
    a, b = b, a + b
    count += 1
