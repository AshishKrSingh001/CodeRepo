from django.http import HttpResponse
from django.shortcuts import redirect, render
from django.views import View
from store.models.product import Product
from store.models.category import Category
from store.models.customer import Customer

class Home(View):
    def get(self,request):
        # request.session.clear()
        cart = request.session.get('cart')
        if not cart:
            request.session['cart'] = {}
        products = None
        Categories = Category.get_all_categories()
        CategoryID = request.GET.get('category')
        if CategoryID:
            products = Product.get_all_products_by_category_id(CategoryID)
        else:
            products = Product.get_all_products()
        return render(request,'store/home.html',locals())
    
    def post(self,request):
        product = request.POST.get('product')
        remove = request.POST.get('remove')
        cart = request.session.get('cart')
        if cart:
            quan = cart.get(product)
            if quan:
                if remove:
                    if quan == 1:
                        cart.pop(product)
                    else:
                        cart[product] = quan - 1
                else:
                    cart[product] = quan + 1
            else:
                cart[product] = 1
        else:
            cart = {}
            cart[product] = 1
        
        request.session['cart'] = cart
        print(request.session['cart'])
        return redirect('home')
