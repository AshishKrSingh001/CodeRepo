from django.shortcuts import render
from django.views import View
from store.models.product import Product

class Cart(View):
    def get(self,request):
        ids = list(request.session.get('cart'))
        products = Product.get_products_by_id(ids)
        if len(products) < 1:
            prod = True
        return render(request,'store/cart.html',locals())
    
    def post(self,request):
        return render(request,'store/cart.html')
