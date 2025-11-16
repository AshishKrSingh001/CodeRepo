# print prime and composite upto N
num = int(input("Enter a Number: "))
sumEvenPos = 0
prime = []
con = []

even = False
for i in range(2,num+1):
    count = 0
    for j in range(2,i//2+1):
        if(i%j == 0):
            count+=1
    if(count==0):
        prime.append(i)
        if (even == True):
            sumEvenPos += i
        even = not even
    else:
        con.append(i)


print("composite numbers are:",con)
print("prime numbers are:",prime)
print("Sum of even numbers is:", sumEvenPos)