import os
file = input("Enter file name: ")
if os.path.exists(file):
    os.remove(file)
    print("FIle deleted successfully")
else:
    print("File not exists")
    