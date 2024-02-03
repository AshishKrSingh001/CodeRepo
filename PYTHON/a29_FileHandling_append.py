f = open("a29.txt","rt")
print(f.read())
f.close()

print("**********************************")

f = open("a29.txt","a")
msg = input("Enter your Message: ")
f.write("\n"+msg)
f.close()

print("**********************************")

f = open("a29.txt","rt")
print(f.read())
f.close()