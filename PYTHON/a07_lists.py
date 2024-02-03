myList = ["Ashish","Aditya","Anish"]
myList.append("Ashish")
for i in myList:
    print(i)
    
print("Length of the list: ",len(myList))
myList.append("Amrit")
myList.sort(reverse = True)

for i in range(0,len(myList)):
    print(myList[i])
    
print("Length of the list: ",len(myList))
print(type(myList))
print(myList[1])
print(myList[-1])
print(myList[-4])
print(myList[1:4])

if "Ashish" in myList:
    print("Exists")
else:
    print("Not exists")
    
#   Methods in lists:

myList.insert(0,"Akash")
myList.append("Kundan")
list2 = ["Arjun","Arun"]
tuple1 = ("Anurag","Anish")
myList.extend(list2)
myList.extend(tuple1)

myList.remove("Ashish")
myList.pop(5)
del myList[len(myList)-1]

myList.sort()

for i in range(0,len(myList)):
    print(myList[i])
myList.reverse()
print(myList)
list1 = myList.copy()
myList.clear()
print(myList)
print(list1)
   