from django.shortcuts import render,redirect
from django.views import View
from . models import Product,Customer,Cart
from django.db.models import Count
from . forms import CustomerRegistrationForm,CustomerProfile
from django.contrib import messages
from django.http import JsonResponse 
from django.db.models import Q
import razorpay
from django.conf import settings
from .models import Payment,OrderPlaced
from django.http import HttpResponseBadRequest
from django.contrib.auth.decorators import login_required
from django.utils.decorators import method_decorator
from django.http import HttpResponse
import logging
# Create your views here.
def home(request):
    return render(request,"app/home.html")

def about(request):
    return render(request,"app/about.html")

def contact(request):
    return render(request,"app/contact.html") 

class CategoryView(View):
    def get(self,request,val):
        product = Product.objects.filter(category=val)
        title = Product.objects.filter(category=val).values('title')
        return render(request,"app/category.html",locals()) 

class CategoryTitle(View):
    def get(self,request,val):
        product = Product.objects.filter(title=val)
        title = Product.objects.filter(category=product[0].category).values('title')
        return render(request,"app/category.html",locals()) 

class ProductDetail(View):
    def get(self,request,pk):
        product = Product.objects.get(pk=pk)
        return render(request,"app/productDetail.html",locals())
    

class CustomerRegistrationView(View):
    def get(self,request):
        form = CustomerRegistrationForm()
        return render(request,"app/customerRegistration.html",locals())
    def post(self,request):
        form = CustomerRegistrationForm(request.POST)
        if form.is_valid():
             # Save the user
            user = form.save()
            # Create a Customer instance and assign the user
            customer = Customer(user=user, **form.cleaned_data)
            customer.save()
            messages.success(request,"Congratulation! User Register Successfully")
        else:
            messages.warning(request,"Invalid Input Data")
        return render(request,"app/customerRegistration.html",locals())
    
class ProfileView(View):
    def get(self,request):
        form = CustomerProfile()
        return render(request,"app/profile.html",locals())
    def post(self,request):
        form = CustomerProfile(request.POST)
        if form.is_valid():
            user = request.user
            name = form.cleaned_data['name']
            locality = form.cleaned_data['locality']
            city = form.cleaned_data['city']
            mobile = form.cleaned_data['mobile']
            state = form.cleaned_data['state']
            zipcode = form.cleaned_data['zipcode']

            reg = Customer(user=user,name=name,locality=locality,mobile=mobile,city=city,state=state,zipcode=zipcode)
            reg.save()
            messages.success(request,"Congratulation! User Data saved Successfully")
        else:
            messages.warning(request,"Invalid Input Data")
        return render(request,"app/profile.html",locals())

def address(request):
    add = Customer.objects.filter(user = request.user)
    return render(request,"app/address.html",locals())

class UpdateAddress(View):
    def get(self,request,pk):
        add = Customer.objects.get(pk=pk)
        form = CustomerProfile(instance=add)
        return render(request,"app/updateAddress.html",locals())
    def post(self,request,pk):
        form = CustomerProfile(request.POST)
        if form.is_valid():
            add = Customer.objects.get(pk=pk)
            add.user = request.user
            add.name = form.cleaned_data['name']
            add.locality = form.cleaned_data['locality']
            add.city = form.cleaned_data['city']
            add.mobile = form.cleaned_data['mobile']
            add.state = form.cleaned_data['state']
            add.zipcode = form.cleaned_data['zipcode']

            add.save()
            messages.success(request,"Congratulation! User Data Updated Successfully")
        else:
            messages.warning(request,"Invalid Input Data")
        return redirect("address")
    
def add_to_cart(request):
    user = request.user
    product_id = request.GET.get('prod_id')
    product = Product.objects.get(id=product_id)
    Cart(user = user,product = product).save()
    return redirect("/cart")

    
def show_cart(request):
    user = request.user
    cart = Cart.objects.filter(user=user)
    amount = 0
    for p in cart:
        value = p.quantity * p.product.discounted_price
        amount = amount + value
    totalamount = amount + 40
    return render(request,'app/addtocart.html',locals())


def plus_cart(request):
    if request.method == "GET":
        prod_id = request.GET.get('prod_id')
        
        try:
            cart_item = Cart.objects.get(Q(user=request.user, product_id=prod_id))
            cart_item.quantity += 1
            cart_item.save()
        except Cart.DoesNotExist:
            return JsonResponse({'error': 'Cart item not found.'}, status=404)
        except Cart.MultipleObjectsReturned:
            cart_items = Cart.objects.filter(Q(user=request.user, product_id=prod_id))
            cart_item = cart_items.first()
            cart_items.exclude(id=cart_item.id).delete()
            cart_item.quantity += 1
            cart_item.save()

        user = request.user
        cart = Cart.objects.filter(user=user)
        amount = sum(item.quantity * item.product.discounted_price for item in cart)
        totalamount = amount + 40

        data = {
            'quantity': cart_item.quantity,
            'amount': amount,
            'totalamount': totalamount
        }
        return JsonResponse(data)

def minus_cart(request):
    if request.method == "GET":
        prod_id = request.GET.get('prod_id')

        try:
            cart_item = Cart.objects.get(Q(user=request.user, product_id=prod_id))
            if cart_item.quantity > 1:
                cart_item.quantity -= 1
                cart_item.save()
            else:
                # Optionally, you might want to handle the case where quantity is 1 and should not be decremented further
                cart_item.quantity = 1  # Ensure it stays at 1
                cart_item.save()
        except Cart.DoesNotExist:
            return JsonResponse({'error': 'Cart item not found.'}, status=404)
        except Cart.MultipleObjectsReturned:
            cart_items = Cart.objects.filter(Q(user=request.user, product_id=prod_id))
            cart_item = cart_items.first()
            cart_items.exclude(id=cart_item.id).delete()
            if cart_item.quantity > 1:
                cart_item.quantity -= 1
                cart_item.save()
            else:
                cart_item.quantity = 1
                cart_item.save()

        user = request.user
        cart = Cart.objects.filter(user=user)
        amount = sum(item.quantity * item.product.discounted_price 
                     for item in cart)
        totalamount = amount + 40

        data = {
            'quantity': cart_item.quantity,
            'amount': amount,
            'totalamount': totalamount
        }
        return JsonResponse(data)
    

def remove_cart(request):
    if request.method == "GET":
        prod_id = request.GET.get('prod_id')
        
        try:
            c = Cart.objects.get(Q(user=request.user) & Q(product=prod_id))
            c.delete()
        except Cart.DoesNotExist:
            return JsonResponse({'error': 'Cart item not found.'}, status=404)
        
        user = request.user
        cart = Cart.objects.filter(user=user)
        amount = sum(item.quantity * item.product.discounted_price for item in cart)
        totalamount = amount + 40
        
        data = {
            'amount': amount,
            'totalamount': totalamount
        }
        return JsonResponse(data)


logger = logging.getLogger(__name__)

class Checkout(View):
    def get(self, request):
        user = request.user
        add = Customer.objects.filter(user=user)
        cart_items = Cart.objects.filter(user=user)
        famount = 0
        for p in cart_items:
            value = p.quantity * p.product.discounted_price
            famount = famount + value
        totalamount = famount + 40
        razoramounnt = int(totalamount * 100)
        client = razorpay.Client(auth=(settings.RAZOR_KEY_ID,settings.RAZOR_KEY_SECRET))
        data = {'amount':razoramounnt,'currency':"INR","receipt":"order_recptid_12"}
        payment_response = client.order.create(data=data)
        print(payment_response)
        order_id = payment_response['id']
        order_status = payment_response['status']
        if order_status == 'created':
            payment = Payment(
                user=user,
                amount=totalamount,
                razorpay_order_id = order_id,
                razorpay_payment_status = order_status
            )
            payment.save()
        return render(request,"app/checkout.html",locals())


class PaymentDone(View):
    def get(self, request):
        try:
            order_id = request.GET.get('order_id')
            payment_id = request.GET.get('payment_id')
            cust_id = request.GET.get('cust_id')

            # Check if cust_id is not None and is not empty
            if cust_id:
                # Cust_id is provided, proceed with your logic
                # Fetch the payment object
                payment = Payment.objects.get(razorpay_order_id=order_id)
                payment.razorpay_payment_id = payment_id
                payment.paid = True
                payment.save()

                # Move items from Cart to OrderPlaced
                user = request.user
                cart_items = Cart.objects.filter(user=user)
                for item in cart_items:
                    OrderPlaced(user=user, customer_id=cust_id, product=item.product, quantity=item.quantity, payment=payment).save()
                    item.delete()

                return render(request, 'app/about.html')
            else:
                # Cust_id is missing or empty, handle the error gracefully
                return HttpResponse("cust_id is missing or empty.", status=400)
        except Payment.DoesNotExist:
            return HttpResponse("Payment record not found.", status=404)
        except Exception as e:
            # Return the error message along with the exception details
            return HttpResponse(f"An error occurred: {str(e)}", status=500)
