f = open("a28.txt","wt")
msg = input("Enter your message: ")
f.write(msg)
f.close()

print("**********************************")

f = open("a28.txt","rt")
print(f.read())
f.close()

print("*********************************")