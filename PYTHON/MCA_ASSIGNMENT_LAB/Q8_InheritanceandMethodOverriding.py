class Employee:
    def __init__(self, name, salary):
        self.name = name
        self.salary = salary

    def total_salary(self):
        return self.salary

class Manager(Employee):
    def __init__(self, name, salary, incentive):
        super().__init__(name, salary)
        self.incentive = incentive

    def total_salary(self):
        return self.salary + self.incentive

m = Manager("Ashish", 50000, 10000)
print(m.name, "Total Salary:", m.total_salary())
