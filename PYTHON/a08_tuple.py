myTuple = ("Ashish","Anish","Aditya","Akash","Abhishek")

print(myTuple)

print(len(myTuple))
for i in myTuple:
    print(i)
   
print(len(myTuple))
print(myTuple)
print(myTuple[2])
print(type(myTuple))
print(myTuple[1:len(myTuple)-1])
print(myTuple[-4:-1])

myList = list(myTuple)
myList.append("Anand")
myList.sort()
myTuple = tuple(myList)
print(myTuple)
print(myList)

# Pack - Unpack
fruits = ("Apple","Mango","cherry")
print(fruits)
(green,yellow,red) = fruits
print(yellow)
print(green)
print(red)

fruits = ("Apple","Mango","cherry")
print(fruits)
(green,*yellow) = fruits
print(yellow)
print(green)

fruits = ("apple", "banana", "cherry")
mytuple = fruits * 2

print(mytuple)
