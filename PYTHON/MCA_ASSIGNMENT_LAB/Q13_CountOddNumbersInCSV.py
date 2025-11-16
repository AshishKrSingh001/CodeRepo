import csv

count = 0
with open("numbers.csv") as f:
    reader = csv.reader(f)
    for row in reader:
        num = int(row[0])
        if num % 2 != 0:
            count += 1
print("Odd numbers:", count)
