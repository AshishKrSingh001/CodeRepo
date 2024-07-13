from django.shortcuts import render, redirect
from django.views import View
from django.core.paginator import Paginator
from store.models import Product, Category

class Home(View):
    def get(self, request):
        cart = request.session.get('cart', {})
        if not cart:
            request.session['cart'] = {}

        category_id = request.GET.get('category')
        if category_id:
            products = Product.get_all_products_by_category_id(category_id)
            if not products:
                category_name = Category.objects.get(id=category_id).name
                category_prod = True
        else:
            products = Product.get_all_products()
            if not products:
                all_prod = True

        paginator = Paginator(products, 9)  # Show 9 products per page
        page_number = request.GET.get('page')
        page_obj = paginator.get_page(page_number)

        categories = Category.get_all_categories()
        
        return render(request, 'store/home.html',locals())

    def post(self, request):
        product_id = request.POST.get('product')
        remove = request.POST.get('remove')

        cart = request.session.get('cart', {})
        if product_id:
            if remove:
                if cart.get(product_id):
                    if cart[product_id] > 1:
                        cart[product_id] -= 1
                    else:
                        del cart[product_id]
            else:
                cart[product_id] = cart.get(product_id, 0) + 1

        request.session['cart'] = cart
        return redirect('home')
