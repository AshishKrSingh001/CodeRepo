'''list=[]
length=int(input("enter length of list:"))
print("Enter ",length, " number: ")
for i in range(length):
    num=(int(input()))
    list.append(num)'''
list=[1, 2, 8, 7]
print(list)
sum=0    
for i in list:
    sum=i+sum
    print(i)
print(sum)    
