import datetime
from django.db import models
from .product import Product
from .customer import Customer

STATUS_CHOICES = (
    ('Accepted','Accepted'),
    ('Packed','Packed'),
    ('On The Way','On The Way'),
    ('Delivered','Delivered'),
    ('Cancel','Cancel'),
    ('Pending','Pending')
)

class Orders(models.Model):
    product = models.ForeignKey(Product,on_delete=models.CASCADE)
    customer = models.ForeignKey(Customer,on_delete=models.CASCADE)
    quantity = models.IntegerField(default=1)
    price = models.IntegerField()
    date = models.DateField(default=datetime.datetime.today)
    address = models.CharField(max_length=50,default="",blank="True")
    phone = models.CharField(max_length=15,default="",blank="True")
    status = models.CharField(max_length=50,choices=STATUS_CHOICES,default='Pending')

    class Meta:
        verbose_name = "Orders"
        verbose_name_plural = "Orders"


    def place_order(self):
        self.save()
