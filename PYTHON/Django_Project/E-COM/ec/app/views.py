from django.shortcuts import get_object_or_404, render,redirect
from django.views import View
from . models import Product,Customer,Cart,Wishlist
from django.db.models import Count
from . forms import CustomerRegistrationForm,CustomerProfile
from django.contrib import messages
from django.http import JsonResponse 
from django.db.models import Q
import razorpay
from django.conf import settings
from .models import Payment,OrderPlaced
from django.http import HttpResponseBadRequest
from django.http import HttpResponse
from django.contrib.auth.decorators import login_required
from django.utils.decorators import method_decorator
import logging
from django.contrib.auth.decorators import login_required


# Create your views here.
def home(request):
    wishItem=0
    totalItem = 0
    if request.user.is_authenticated:
        totalItem = len(Cart.objects.filter(user=request.user))
        wishItem = len(Wishlist.objects.filter(user=request.user))

    return render(request,"app/home.html",locals())

def about(request):
    wishItem=0
    totalItem = 0
    if request.user.is_authenticated:
        totalItem = len(Cart.objects.filter(user=request.user))
        wishItem = len(Wishlist.objects.filter(user=request.user))
    return render(request,"app/about.html",locals())


@method_decorator(login_required, name='dispatch')
class CategoryView(View):
    def get(self,request,val):
        wishItem=0
        totalItem = 0
        if request.user.is_authenticated:
            totalItem = len(Cart.objects.filter(user=request.user))
            wishItem = len(Wishlist.objects.filter(user=request.user))
        product = Product.objects.filter(category=val)
        title = Product.objects.filter(category=val).values('title')
        return render(request,"app/category.html",locals()) 
@method_decorator(login_required, name='dispatch')
class CategoryTitle(View):
    def get(self,request,val):
        wishItem=0
        totalItem = 0
        if request.user.is_authenticated:
            totalItem = len(Cart.objects.filter(user=request.user))
            wishItem = len(Wishlist.objects.filter(user=request.user))
        product = Product.objects.filter(title=val)
        title = Product.objects.filter(category=product[0].category).values('title')
        return render(request,"app/category.html",locals()) 
@method_decorator(login_required, name='dispatch')
class ProductDetail(View):
    def get(self,request,pk):
        product = Product.objects.get(id=pk)
        wishlist = Wishlist.objects.filter(Q(product=product) & Q(user=request.user))
        wishItem=0
        totalItem = 0
        if request.user.is_authenticated:
            totalItem = len(Cart.objects.filter(user=request.user))
            wishItem = len(Wishlist.objects.filter(user=request.user))
        return render(request,"app/productDetail.html",locals())
    
class CustomerRegistrationView(View):
    def get(self,request):
        form = CustomerRegistrationForm()
        wishItem=0
        totalItem = 0
        if request.user.is_authenticated:
            totalItem = len(Cart.objects.filter(user=request.user))
            wishItem = len(Wishlist.objects.filter(user=request.user))
        return render(request,"app/customerRegistration.html",locals())
    def post(self,request):
        form = CustomerRegistrationForm(request.POST)
        if form.is_valid():
             # Save the user
            form.save()
            # # Create a Customer instance and assign the user
            # customer = Customer(user=user, **form.cleaned_data)
            # customer.save()
            messages.success(request,"Congratulation! User Register Successfully")
        else:
            messages.warning(request,"Invalid Input Data")
        return render(request,"app/customerRegistration.html",locals())
@method_decorator(login_required, name='dispatch')    
class ProfileView(View):
    def get(self,request):
        form = CustomerProfile()
        wishItem=0
        totalItem = 0
        if request.user.is_authenticated:
            totalItem = len(Cart.objects.filter(user=request.user))
            wishItem = len(Wishlist.objects.filter(user=request.user))
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
@login_required
def address(request):
    add = Customer.objects.filter(user = request.user)
    wishItem=0
    totalItem = 0
    if request.user.is_authenticated:
        totalItem = len(Cart.objects.filter(user=request.user))
        wishItem = len(Wishlist.objects.filter(user=request.user))
    return render(request,"app/address.html",locals())
@method_decorator(login_required, name='dispatch')
class UpdateAddress(View):
    def get(self,request,pk):
        add = Customer.objects.get(pk=pk)
        form = CustomerProfile(instance=add)
        wishItem=0
        totalItem = 0
        if request.user.is_authenticated:
            totalItem = len(Cart.objects.filter(user=request.user))
            wishItem = len(Wishlist.objects.filter(user=request.user))
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
@login_required   
def add_to_cart(request):
    user = request.user
    product_id = request.GET.get('prod_id')
    product = Product.objects.get(id=product_id)
    Cart(user = user,product = product).save()
    return redirect("/cart")

@login_required   
def show_cart(request):
    user = request.user
    cart = Cart.objects.filter(user=user)
    amount = 0
    for p in cart:
        value = p.quantity * p.product.discounted_price
        amount = amount + value
    totalamount = amount + 40
    wishItem=0
    totalItem = 0
    if request.user.is_authenticated:
        totalItem = len(Cart.objects.filter(user=request.user))
        wishItem = len(Wishlist.objects.filter(user=request.user))
    return render(request,'app/addtocart.html',locals())

@login_required
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
@login_required
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
    
@login_required
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
@method_decorator(login_required, name='dispatch')
class Checkout(View):
    def get(self, request):
        user = request.user
        add = Customer.objects.filter(user=user)
        cart_items = Cart.objects.filter(user=user)
        wishItem=0
        totalItem = 0
        if request.user.is_authenticated:
            totalItem = len(Cart.objects.filter(user=request.user))
            wishItem = len(Wishlist.objects.filter(user=request.user))
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

@method_decorator(login_required, name='dispatch')
class PaymentDone(View):
    def get(self, request):
        print(10)
        try:
            order_id = request.GET.get('order_id')
            payment_id = request.GET.get('payment_id')
            cust_id = int(request.GET.get('cust_id'))
            #print(cust_id)

            # Check if cust_id is not None and is not empty
            if cust_id:
                # Cust_id is provided, proceed with your logic
                # Fetch the payment object
                customer = Customer.objects.get(id=cust_id)

                payment = Payment.objects.get(razorpay_order_id=order_id)
                payment.razorpay_payment_id = payment_id
                payment.paid = True
                payment.save()

                # Move items from Cart to OrderPlaced
                user = request.user
                cart_items = Cart.objects.filter(user=user)
                for item in cart_items:
                    OrderPlaced(user=user, customer=customer, product=item.product, quantity=item.quantity,payment=payment).save()
                    item.delete()

                return render(request, 'app/orders.html')
            else:
                # Cust_id is missing or empty, handle the error gracefully
                return HttpResponse("cust_id is missing or empty.", status=400)
        except Payment.DoesNotExist:
            return HttpResponse("Payment record not found.", status=404)
        except Exception as e:
            # Return the error message along with the exception details
            return HttpResponse(f"An error occurred: {str(e)}", status=500)

@login_required
def buynow(request,pk):
    user = request.user
    add = Customer.objects.filter(user=user)
    product = Product.objects.get(id=pk)
    wishItem=0
    totalItem = 0
    if request.user.is_authenticated:
        totalItem = len(Cart.objects.filter(user=request.user))
        wishItem = len(Wishlist.objects.filter(user=request.user))
    totalamount = product.discounted_price + 40
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
    return render(request,"app/buynow.html",locals())

@method_decorator(login_required, name='dispatch')
class BuyNowPaymentDone(View):
    def get(self, request):
        try:
            order_id = request.GET.get('order_id')
            payment_id = request.GET.get('payment_id')
            cust_id = int(request.GET.get('cust_id'))
            prod_id = request.GET.get('prod_id')
            #print(cust_id)

            # Check if cust_id is not None and is not empty
            if cust_id:
                # Cust_id is provided, proceed with your logic
                # Fetch the payment object
                customer = Customer.objects.get(id=cust_id)

                payment = Payment.objects.get(razorpay_order_id=order_id)
                payment.razorpay_payment_id = payment_id
                payment.paid = True
                payment.save()

                # Move items from Cart to OrderPlaced
                user = request.user
                product = Product.objects.get(id=prod_id)
                
                OrderPlaced(user=user, customer=customer, product=product, quantity=1,payment=payment).save()

                return render(request, 'app/orders.html')
            else:
                # Cust_id is missing or empty, handle the error gracefully
                return HttpResponse("cust_id is missing or empty.", status=400)
        except Payment.DoesNotExist:
            return HttpResponse("Payment record not found.", status=404)
        except Exception as e:
            # Return the error message along with the exception details
            return HttpResponse(f"An error occurred: {str(e)}", status=500)
@login_required        
def orders(request):
    orderPlaced = OrderPlaced.objects.filter(user=request.user)
    wishItem=0
    totalItem = 0
    if request.user.is_authenticated:
        totalItem = len(Cart.objects.filter(user=request.user))
        wishItem = len(Wishlist.objects.filter(user=request.user))
    return render(request,"app/orders.html",locals())
    
@login_required
def plus_wishlist(request):
    if request.method == "GET":
        prod_id = request.GET['prod_id']
        product = Product.objects.get(id=prod_id)
        user = request.user
        Wishlist(user=user,product=product).save()
        data = {
            "message":"Wishlist Added Successfully",
        }
        return JsonResponse(data)
@login_required   
def minus_wishlist(request):
    if request.method == "GET":
        prod_id = request.GET['prod_id']
        product = Product.objects.get(id=prod_id)
        user = request.user
        Wishlist.objects.filter(user=user,product=product).delete()
        data = {
            "message":"Wishlist Remove Successfully",
        }
        return JsonResponse(data)
@login_required
def wishlists(request):
    user = request.user
    wishlist_items = Wishlist.objects.filter(user=user)
    products = [item.product for item in wishlist_items]
    context = {
        'products': products,
    }
    return render(request, "app/wishlist.html", context)

@login_required
def add_all_to_cart(request):
    user = request.user
    wishlist_items = Wishlist.objects.filter(user=user)
    for item in wishlist_items:
        # Check if the item already exists in the cart
        cart_item, created = Cart.objects.get_or_create(
            user=user,
            product=item.product,
            defaults={'quantity': 1}
        )
        if not created:
            # If the item already exists in the cart, increase the quantity
            cart_item.quantity += 1
            cart_item.save()
    
    # Delete all items from the wishlist
    wishlist_items.delete()
    
    # Redirect to a page showing the cart, assuming 'cart' is the name of that view
    return redirect('showcart')


@login_required
def search(request):
    query = request.GET['search']
    wishItem=0
    totalItem = 0
    if request.user.is_authenticated:
        totalItem = len(Cart.objects.filter(user=request.user))
        wishItem = len(Wishlist.objects.filter(user=request.user))
    product = Product.objects.filter(Q(title__icontains=query))
    return render(request,"app/search.html",locals())
