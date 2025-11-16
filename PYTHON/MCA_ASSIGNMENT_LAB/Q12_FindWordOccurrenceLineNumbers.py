word = input("Enter word to search: ")
with open("input.txt", "r") as f:
    for i, line in enumerate(f, 1):
        if word in line:
            print(f"Found on line {i}")
