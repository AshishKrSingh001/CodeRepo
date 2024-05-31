from django.shortcuts import render
from django.http import HttpResponse

# Create your views here.
def home(request):
    return render(request,"app/index.html",locals())
def about(request):
    return render(request,"app/about.html",locals())
def gallary(request):
    try:
        # email = request.GET['email']
        # password = request.GET['password']
        email = request.GET.get('email')
        password = request.GET.get('password')
        print("Email: ",email,"\nPassword: ",password)
    except:
        pass
    return render(request,"app/gallary.html",locals())