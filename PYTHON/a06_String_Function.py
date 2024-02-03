a = "Hello"

print(a)

print(a.upper())
print(a.lower())

b = "   ashish   "
print(b)
print(b.strip())

print(a.replace("e","a"))
a.replace("a","e")
print(a)
a = "Ashish Kumar SIngh"
print(a.split(" "))

print(b.strip().upper() + " KUMAR")
x = "My name is {}"

print(x.format(a))

name = "Ashish"
age = 23
salary = 0.0
y = "My name is {0}, my age is {1} and my Salary is {2}"
print(y.format(name,age,salary))