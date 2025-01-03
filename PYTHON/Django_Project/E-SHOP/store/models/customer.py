from django.db import models

class Customer(models.Model):
    first_name = models.CharField(max_length=50)
    last_name = models.CharField(max_length=50)
    email = models.EmailField(max_length=50)
    password = models.CharField(max_length=500)
    phone = models.CharField(max_length=15)

    def __str__(self):
        return self.first_name

    def register(self):
        self.save()

    def isExists(self):
        if Customer.objects.filter(email = self.email):
            return True
        else:
            return False

    @staticmethod 
    def getCustomer_by_email(email):
        try:
            return Customer.objects.get(email = email)
        except Customer.DoesNotExist:
            return None
        