thisSet = {"Apple","Mango","Banana","Cherry","JackFruit"}
print(thisSet)
print(type(thisSet))
print(len(thisSet))

print("Value of Set")
for i in thisSet:
    print(i)
thisSet.add("Cucumber")
print(thisSet)

list1 = ["Guava","PineApple","Grapes"]
thisSet.update(list1)
print(thisSet)

thisSet.pop()
print(thisSet)
thisSet.remove("Apple")
print(thisSet)
thisSet.discard("PineApple")
print(thisSet)

#thisSet.clear()
print(thisSet)

set2 = set(list1)
print(set2)

print(set2.union(thisSet))
print(thisSet.union(set2))

print(thisSet.intersection(set2))

print(thisSet.symmetric_difference(set2))