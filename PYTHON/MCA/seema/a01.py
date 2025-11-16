list=[11,22,33,-1,0,90,9]
print(list)
# print(list[2])
# print(len(list))
# list.remove(90)
#print(list)
#list.reverse()
#list.insert(2, 100)
# print(list[0:4])

# list.pop(2)
# print(list)

min=list[0]
# max=list[0]
for i in list:
    if min>i:
        min=i

print(min)