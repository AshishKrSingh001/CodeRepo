#x = 20
try:
    print(x)
    print("Hi")
except:
    print("Something Went wrong")
else:
    print("Nothing went wrong")
finally:
    print("bye")
    
def ageEvaluate(age):
    if(age>=18 and age<120):
        print("You are eligible for vote")
    elif(age > 0 and age < 18):
        print("You are not eligible for vote")
    else:
        raise Exception("Invalid age")
        
        
print("*******************************")        
age = int(input("Enter your age: "))
try:
    ageEvaluate(age)
except:
    print("Something Went wrong")
else:
    print("Nothing went wrong")
finally:
    print("bye")