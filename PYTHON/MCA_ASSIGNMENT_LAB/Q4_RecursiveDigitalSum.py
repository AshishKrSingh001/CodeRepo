def digital_sum(n):
    if n < 10:
        return n
    return n % 10 + digital_sum(n // 10)

num = int(input("Enter a number: "))
print("Digital Sum:", digital_sum(num))
