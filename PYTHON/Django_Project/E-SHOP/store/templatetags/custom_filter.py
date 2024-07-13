# myapp/templatetags/custom_filters.py

from django import template

register = template.Library()

@register.filter(name='add_currency')
def add_currency(price):
    # Convert the price to a string
    amt = str(price)
    # Separate the last three digits
    last_three = amt[-3:]
    # Get the remaining digits
    other_numbers = amt[:-3]
    # Format the remaining digits by adding commas at appropriate places
    if other_numbers:
        last_three = ',' + last_three
    # Reverse and format the other_numbers
    result = other_numbers[::-1]
    result = ''.join([result[i] + ',' if (i+1) % 2 == 0 and i+1 != len(result) else result[i] for i in range(len(result))])
    # Reverse back the result
    result = result[::-1]
    # Concatenate the formatted numbers
    formatted_amount = result + last_three
    return "₹ " + formatted_amount
