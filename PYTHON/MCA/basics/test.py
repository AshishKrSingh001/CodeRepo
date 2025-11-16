class Cow:
    no_of_legs = 2
    def __init__(self, x):
        print("This is Cow constructor", x)

class Gir(Cow):
    def __init__(self):
        print("This is Gir constructor")

gir = Gir("Hello")