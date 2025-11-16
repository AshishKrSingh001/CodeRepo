from django.shortcuts import render,redirect
from django.views import View
from store.models.customer import Customer
from store.models.orders import Orders
from store.models.product import Product

class Checkout(View):
    def get(self,request):
        ids = list(request.session.get('cart'))
        products = Product.get_products_by_id(ids)
        return render(request,'store/cart.html',locals())
    
    def post(self,request):
        phone = request.POST.get('phone')
        address = request.POST.get('address')
        customer_id = request.session.get('customer')
        print(customer_id)
        customer = Customer.objects.get(id=customer_id)
        cart = request.session.get('cart')
        products = Product.get_products_by_id(list(cart.keys()))
        
        for product in products:
            order = Orders(customer=customer,product=product,price=product.price,quantity = cart.get(str(product.id)),address=address,phone=phone)
            print(order.place_order())
        return redirect('orders')

    def place_order(self):
        self.save()

        