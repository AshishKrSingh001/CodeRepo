from collections import Counter

with open("input.txt", "r") as f:
    words = f.read().split()

freq = Counter(words)

with open("output.txt", "w") as f:
    for word, count in freq.items():
        f.write(f"{word}: {count}\n")
