from django import template
from .custom_filter import add_currency

register = template.Library()

@register.filter(name='is_in_cart')
def is_in_cart(product, cart):
    try:
        keys = cart.keys()
        for id in keys:
            if int(id) == product.id:
                return True
    except ValueError:
        return False

@register.filter(name='count_in_cart')
def count_in_cart(product, cart):
    try:
        keys = cart.keys()
        for id in keys:
            if int(id) == product.id:
                return cart.get(id)
    except ValueError:
        return 0

@register.filter(name='total_price')
def total_price(product, cart):
    return product.price * count_in_cart(product,cart)

@register.filter(name='total_cart_price')
def total_cart_price(products,cart):
    sum = 0
    for p in products:
        sum += total_price(p,cart)
    return sum