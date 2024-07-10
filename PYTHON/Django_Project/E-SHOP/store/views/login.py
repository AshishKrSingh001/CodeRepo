from django.views import View
from django.shortcuts import redirect, render
from django.views import View
from store.models.customer import Customer
from django.contrib.auth.hashers import check_password

# login page
class Signin(View):
    # get method
    def get(self,request):
        return render(request,'store/login.html',locals())
    # post method
    def post(self,request):
        postData = request.POST
        email = postData.get('email')
        password = postData.get('password')

        customer = Customer.getCustomer_by_email(email)
        error_message = None
        if customer:
            if check_password(password,customer.password):
                request.session['customer'] = customer.id
                return redirect('home')
            else:
                error_message = "Entered Email or Password Invalid !!"
        else:
            error_message = "Entered Email or Password Invalid !!"
        return render(request,'store/login.html',locals())

def logout(request):
    request.session.clear()
    return redirect('home')