from django.shortcuts import render,redirect
from django.core.paginator import Paginator

from django.views import View
from store.models.customer import Customer
from store.models.orders import Orders
from store.models.product import Product

class Order(View):
    def get(self,request):
        customer_id = request.session.get('customer')
        customer = Customer.objects.get(id=customer_id)
        orders = Orders.objects.filter(customer=customer).order_by('-date')
        paginator = Paginator(orders, 9)  # Show 9 orders per page

        page_number = request.GET.get('page')
        page_obj = paginator.get_page(page_number)
        if len(orders) < 1:
            ord = True
        return render(request,'store/orders.html',locals())
    
        

        