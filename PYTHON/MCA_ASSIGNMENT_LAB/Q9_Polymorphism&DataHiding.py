import math

class Circle:
    def __init__(self, radius):
        self.__radius = radius  # private

    def area(self):
        return math.pi * self.__radius**2

class Rectangle:
    def __init__(self, length, width):
        self.__length = length  # private
        self.__width = width

    def area(self):
        return self.__length * self.__width

def show_area(shape):
    print("Area:", shape.area())

c = Circle(5)
r = Rectangle(4, 6)
show_area(c)
show_area(r)
