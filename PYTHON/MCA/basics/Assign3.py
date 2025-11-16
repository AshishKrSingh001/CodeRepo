def factorial(num):
    if(num<=1):
        return 1
    return num*factorial(num-1)

def element_of_cosx(i, x):
    return (pow(-1, i)*pow(x, 2*i))/factorial(2*i)

def element_of_sinx(i, x):
    return (pow(-1, i)*pow(x, 2*i+1))/factorial(2*i+1)

def cosx(valueofx, k):
    value = 0
    for i in  range(10):
        value += element_of_cosx(i, valueofx)
    return value

def sinx(valueofx, k):
    value = 0
    for i in  range(k):
        value += element_of_sinx(i, valueofx)
    return value

x = 3.14

print(pow(cosx(x, 10), 2)+pow(sinx(x, 10), 2))