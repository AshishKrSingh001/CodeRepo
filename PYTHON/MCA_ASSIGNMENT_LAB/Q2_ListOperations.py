nums = list(map(int, input("Enter integers separated by spaces: ").split()))

nums = list(set(nums))  # Remove duplicates
nums.sort()  # Ascending
print("Ascending:", nums)
print("Descending:", nums[::-1])

print("Second smallest:", nums[1])
print("Second largest:", nums[-2])
