from django.shortcuts import render,HttpResponse
from .models import Employee,Role,Department
from datetime import datetime
from django.db.models import Q


def all_emp(request):
    #return render(request,"all_emp.html")
    emps = Employee.objects.all()
    context = {
        'emps':emps
    }
    print(context)
    return render(request, 'all_emp.html',context)

def add_emp(request):
    if request.method == "POST":
        firstName = request.POST['firstName']
        middleName = request.POST['middleName']
        lastName = request.POST['lastName']
        salary = request.POST['salary']
        bonus = request.POST['bonus']
        phone = request.POST['phone']
        dept_id = request.POST['dept']  # Assuming department ID is passed from the form
        role_id = request.POST['role']  # Assuming role ID is passed from the form
        
        # Fetch the department and role objects based on IDs
        department = Department.objects.get(pk=dept_id)
        role = Role.objects.get(pk=role_id)

        # Create new employee object and save to the database
        new_emp = Employee(firstName=firstName, middleName=middleName, lastName=lastName, salary=salary, bonus=bonus, phone=phone, dept=department, role=role, hireDate=datetime.now())
        new_emp.save()
        
        return HttpResponse("Employees added successfully")
    elif request.method == "GET":
        departments = Department.objects.all()
        roles = Role.objects.all()
        return render(request, "add_emp.html", {'departments': departments, 'roles': roles})
    else:
        return HttpResponse("An Exception occurred! Employee has not been added")
def remove_emp(request,emp_id = 0):
    if emp_id:
        try:
            emp_to_be_removed = Employee.objects.get(id = emp_id)
            emp_to_be_removed.delete()
            return HttpResponse("Employee removed successfully!")
        except:
            return HttpResponse("Please Enter a valid id!")
    emps = Employee.objects.all()
    context = {
        'emps':emps
    }
    print(context)
    return render(request,"remove_emp.html",context)

def filter_emp(request):
    if request.method == "POST":
        name = request.POST['name']
        dept = request.POST['dept']
        role = request.POST['role']
        emps = Employee.objects.all()
        if name:
            emps.filter(Q(firstName__icontains = name) | Q(middleName__icontains = name) | Q(lastName__icontains = name))
        if dept:
            emps.filter(dept__name__icontains = dept)
        if role:
            emps = emps.filter(role__name__icontains = role)
        context = {
            'emps':emps
        }
        return render(request,"all_emp.html",context)
    elif request.method == 'GET':
        return render(request,"filter_emp.html")
    else:
        return HttpResponse("An exception occured")
        

    