class Person:
    def __init__(self,fname,mname,lname):
        self.fname = fname
        self.mname = mname
        self.lname = lname
    def getName(self):
        return self.fname + " " + self.mname + " "  + self.lname

class Employee(Person):
    def __init__(self,fname,mname,lname,id,dept):
        super().__init__(fname,mname,lname)
        self.id = id
        self.dept = dept
    def display(self):
        print("Name :",super().getName()," \nId: ",self.id,"\nDepartment: ",self.dept)

fname = input("Enter your First name: ")
mname = input("Enter your Middle name: ")
lname = input("Enter your Last name: ")
id = int(input("Enter Id: "))
dept = input("Enter department name: ")
fname = fname.strip()
mname = mname.strip()
lname = lname.strip()
obj = Person(fname,mname,lname)
print(obj.getName())  

emp = Employee(fname,mname,lname,id,dept)   
emp.display()