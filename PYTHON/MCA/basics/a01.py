while(True):
    num = int(input("Enter a number: "))
    n = num
    if(num<10):
        print("try again")
        continue
    rev = 0
    while(n>0):
        d = n%10
        rev = rev * 10 + d
        n = n//10
    if(rev == num):
        print("Game over")
        break
    else:
        print("try again")