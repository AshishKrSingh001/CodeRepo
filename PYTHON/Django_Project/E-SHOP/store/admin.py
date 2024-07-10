from django.contrib import admin

from store.models.customer import Customer
from .models.product import Product
from .models.category import Category

class AdminProduct(admin.ModelAdmin):
    list_display = ['name','price','category']

class AdminCustomer(admin.ModelAdmin):
    list_display = ['first_name','last_name','email','phone']


# Register your models here.
admin.site.register(Product,AdminProduct)
admin.site.register(Category)
admin.site.register(Customer,AdminCustomer)