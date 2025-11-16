def square(x):
    return x * x

num = [10, 15, 30]

print(num)
print(list(map(square, num)))
print(list(filter(lambda x: x%2==0, num)))
print(num)
for i in num:
    print(square(i))

# def add(x,y):
#     return x+y 

# ladd = lambda x,y:x+y
# print(add(10, 20))
# print(ladd(10, 20))
