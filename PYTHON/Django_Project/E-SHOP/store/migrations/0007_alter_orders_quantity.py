# Generated by Django 5.0.6 on 2024-07-10 19:03

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('store', '0006_orders_address_orders_phone'),
    ]

    operations = [
        migrations.AlterField(
            model_name='orders',
            name='quantity',
            field=models.IntegerField(blank='True', default=1),
        ),
    ]
