mystr = "Ashish"
myit1 = iter(mystr)
for i in mystr:
    print(next(myit1))

mylist = [10,20,30,50,40,60,70,80,90]
myit2 = iter(mylist)
for i in mylist:
    print(next(myit2))
    
mytuple = (1,2,3,6,5,4,7,8,9,36,98,74,52)
myit3 = iter(mytuple)
for i in mytuple:
    print(next(myit3))

