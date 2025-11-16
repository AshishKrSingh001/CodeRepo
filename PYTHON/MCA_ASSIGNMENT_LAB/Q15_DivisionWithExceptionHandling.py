try:
    a = int(input("Enter first number: "))
    b = int(input("Enter second number: "))
    print("Result:", a / b)
except ValueError:
    print("Invalid input! Enter numeric values.")
except ZeroDivisionError:
    print("Cannot divide by zero!")
except Exception as e:
    print("Unexpected error:", e)
