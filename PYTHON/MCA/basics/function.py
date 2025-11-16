def add(a, b):
    return a+b

# print the sum of the factorial of a +ve integer
def fact(num):
    if(num<=1):
        return 1
    return num*fact(num-1)

def factorial(n):
    fact=1
    for i in range(1,n+1):
        fact=fact*i
    return fact

def fun(num):
    sum=0
    for i in range(1,num+1):
        sum=sum+pow(i,i)
    return sum

k=5
def sinx(x):
    sum=0
    for i in range(0,k+1):
        print(pow(x,2*i+1))
        sum=sum+((pow(-1,i)*pow(x,(2*i+1)))/(fact(2*i+1)))
        # print(sum)
    return sum
print(sinx(30))