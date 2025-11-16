grade = ""
marks = int(input("Enter Marks: "))
if(marks >= 80 and marks < 100):
    grade = "Excellent"
elif(marks >= 60 and marks < 80):
    grade = "Good"
else:
    grade = "poor"
    
print(grade)