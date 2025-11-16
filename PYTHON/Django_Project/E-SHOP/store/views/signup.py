from django.shortcuts import redirect, render
from django.views import View
from store.models.customer import Customer
from django.contrib.auth.hashers import make_password


# Signup Page
class Signup(View):
    # get method
    def get(self,request):
        return render(request,'store/signup.html',locals())
    # post method
    def post(self,request):
        return self.registerUser(request)
    # validate Customer for signup
    def validateCustomer(self,customer):
        error_message = None
        if(not customer.first_name):
            error_message = "First Name Required !!"
        elif customer.first_name:
            if(len(customer.first_name) < 4):
                error_message = "First Name must be 4 character long"

        if(not customer.last_name):
            error_message = "Last Name Required !!"
        elif customer.last_name:
            if(len(customer.last_name) < 3):
                error_message = "Last Name must be 3 character long"

        if(not customer.phone):
            error_message = "Phone Number Required !!"
        elif customer.phone:
            if(len(customer.phone) < 10):
                error_message = "Phone Number must be 10 character long"

        if(not customer.password):
            error_message = "Password Required !!"
        elif customer.password:
            if(len(customer.password) < 6):
                error_message = "Password must be 6 character long"
        
        # check if customer already Exists
        if customer.isExists():
                error_message = "Email address already exists"
            
        return error_message    
    # signup page (Post Method)
    def registerUser(self,request):
        postData = request.POST

        first_name = postData.get('firstname')
        last_name = postData.get('lastname')
        email = postData.get('email')
        phone = postData.get('phone')
        password = postData.get('password')
        confirm_password = postData.get('confirm_password')

        error_message = None

        if(password == confirm_password):
            customer = Customer(first_name=first_name,last_name=last_name,email=email,phone=phone,password=password)
            error_message = self.validateCustomer(customer)
        else:
            error_message = "Password doesn't matched"    

        if not error_message:
            customer.password = make_password(customer.password)
            customer.register()
            return redirect('login')
        else:
            return render(request,"store/signup.html",locals())
    
