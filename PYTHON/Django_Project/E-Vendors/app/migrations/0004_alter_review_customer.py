# Generated by Django 5.1.1 on 2024-09-23 09:44

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('app', '0003_remove_product_stock_quantity_and_more'),
    ]

    operations = [
        migrations.AlterField(
            model_name='review',
            name='customer',
            field=models.CharField(max_length=200),
        ),
    ]
