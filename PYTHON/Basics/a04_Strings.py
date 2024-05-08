a = '''
    Like many other popular programming languages, strings in Python are arrays of bytes representing unicode characters.

    However, Python does not have a character data type, a single character is simply a string with a length of 1.

    Square brackets can be used to access elements of the string.
'''
print(a)
print(a[10])

for x in a:
    print(x,end=" ")
print(len(a))
print("Like" in a)
print("off" not in a)

