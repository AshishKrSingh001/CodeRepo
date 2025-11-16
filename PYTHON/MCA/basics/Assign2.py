# print binary upto n bits except binary containing '11'
def print_binaries(n):
    for i in range(2**n):
        binary_str = format(i, 'b').zfill(n)
        if("11" not in binary_str):
            print(binary_str)

# Example usage:
N = int(input("Enter the number of bits N: "))
print_binaries(N)

