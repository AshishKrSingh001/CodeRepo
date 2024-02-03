import os
file = input("Enter path of the file: ")
if os.path.exists(file):
    os.remove(file)
    print("File deleted successful")
else:
    print("File not exists")