import os, shutil

try:
    os.rename("old.txt", "new.txt")
    shutil.copy("new.txt", "copy.txt")
    os.remove("copy.txt")
    print("File operations successful.")
except Exception as e:
    print("Error:", e)
