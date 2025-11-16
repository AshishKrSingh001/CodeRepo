old = input("Word to replace: ")
new = input("New word: ")

with open("input.txt", "r") as f:
    data = f.read()

data = data.replace(old, new)

with open("modified.txt", "w") as f:
    f.write(data)
