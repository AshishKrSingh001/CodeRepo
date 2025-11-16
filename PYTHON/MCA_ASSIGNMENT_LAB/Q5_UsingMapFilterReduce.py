from functools import reduce

nums = list(map(int, input("Enter numbers: ").split()))
even_nums = list(filter(lambda x: x % 2 == 0, nums))
sum_squares = reduce(lambda x, y: x + y, map(lambda x: x**2, even_nums))
print("Sum of squares of even numbers:", sum_squares)
