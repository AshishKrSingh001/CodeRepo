file1 = open("a26_Exception_Handling.py","rt")
print(file1.read())

print("********************************")

f = open("a27_FileHandling_read.py","r")
print(f.read(200))
print("********************************")

print(f.readline())

print("*******************************")

for i in f:
    print(i)
 
f.close()
file1.close()