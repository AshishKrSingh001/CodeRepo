import threading

def print_even(n):
    for i in range(2, n+1, 2):
        print("Even:", i)

def print_odd(n):
    for i in range(1, n+1, 2):
        print("Odd:", i)

n = int(input("Enter n: "))
t1 = threading.Thread(target=print_even, args=(n,))
t2 = threading.Thread(target=print_odd, args=(n,))
t1.start()
t2.start()
t1.join()
t2.join()
