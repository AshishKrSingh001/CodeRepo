class Person():
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def display(self):
        print(f"Name: {self.name}\nAge: {self.age}")

class Student(Person):
    def __init__(self, name, age, grade):
        super().__init__(name, age)
        self.grade = grade

    def display(self):
        super().display()
        print(f"Grade: {self.grade}")

# class Employee(Person):
#     def __init__(self,name, age, salary):
#         super().__init__(name, age)
#         self.salary = salary

#     def display(self):
#         print(f"Grade: {self.grade}")

s = Student("John", 20, 74)
s.display()