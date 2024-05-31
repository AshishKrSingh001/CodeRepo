from django import forms
from django.contrib.auth.forms import UserCreationForm, AuthenticationForm, UsernameField,PasswordChangeForm,SetPasswordForm,PasswordResetForm
from django.contrib.auth.models import User
from django.core.validators import RegexValidator

from .models import Customer

class LoginForm(AuthenticationForm):
    username = forms.CharField(widget=forms.TextInput(attrs={'autofocus':'True','class':'form-control'}))
    password = forms.CharField(label='Password',widget=forms.PasswordInput(attrs={'class':'form-control'}))

class CustomerRegistrationForm(UserCreationForm):
    username = forms.CharField(widget=forms.TextInput(attrs={'autofocus':'True','class':'form-control'}))
    email = forms.EmailField(widget=forms.EmailInput(attrs={'class':'form-control'}))
    password1 = forms.CharField(label='Password',widget=forms.PasswordInput(attrs={'class':'form-control','id': 'password'}))
    password2 = forms.CharField(label='Confirm Password',widget=forms.PasswordInput(attrs={'class':'form-control','id': 'password'}))

    class Meta:
        model = User
        fields = ["username","email","password1","password2"]

class MyPasswordResetForm(PasswordResetForm):
    email = forms.EmailField(widget=forms.EmailInput(attrs={'class': 'form-control'}))
    def clean_email(self):
        email = self.cleaned_data.get('email')
        if not User.objects.filter(email=email).exists():
            raise forms.ValidationError("This email does not exist.")
        return email
    # username = forms.CharField(widget=forms.TextInput(attrs={'class': 'form-control'}))
    # def clean_username(self):
    #     username = self.cleaned_data.get('username')
    #     if not User.objects.filter(username=username).exists():
    #         raise forms.ValidationError("This username does not exist.")
    #     return username


class MySetPasswordForm(SetPasswordForm):
    new_password1 = forms.CharField(label='New Password', widget=forms.PasswordInput(attrs={'class': 'form-control'}))
    new_password2 = forms.CharField(label='Confirm New Password', widget=forms.PasswordInput(attrs={'class': 'form-control'}))

class MyPasswordChangeForm(PasswordChangeForm):
    old_password = forms.CharField(label='Old Password',widget=forms.PasswordInput(attrs={'autofocus':'True','autocomplete':'current-password','class':'form-control'}))
    new_password1 = forms.CharField(label='New Password',widget=forms.PasswordInput(attrs={'autofocus':'True','autocomplete':'current-password','class':'form-control'}))
    new_password2 = forms.CharField(label='Confirm Password',widget=forms.PasswordInput(attrs={'autofocus':'True','autocomplete':'current-password','class':'form-control'}))


# forms.py
from django import forms
from django.core.validators import RegexValidator
from .models import Customer

class CustomerProfile(forms.ModelForm):
    mobile = forms.CharField(
        label='Mobile Number',
        validators=[
            RegexValidator(
                regex=r'^\+?1?\d{9,15}$',
                message="Phone number must be entered in the format: '+999999999'. Up to 15 digits allowed."
            ),
        ],
        widget=forms.NumberInput(attrs={'class': 'form-control'}),
    )

    zipcode = forms.CharField(
        label='Zip Code',
        validators=[
            RegexValidator(
                regex=r'^\d{5}(?:[-\s]\d{4})?$',
                message="Zip Code must be in the format: '12345' or '12345-6789'."
            ),
        ],
        widget=forms.NumberInput(attrs={'class': 'form-control'}),
    )

    class Meta:
        model = Customer
        fields = ['name', 'locality', 'city', 'mobile', 'state', 'zipcode']
        widgets = {
            'name': forms.TextInput(attrs={'class': 'form-control'}),
            'locality': forms.TextInput(attrs={'class': 'form-control'}),
            'city': forms.TextInput(attrs={'class': 'form-control'}),
            'state': forms.Select(attrs={'class': 'form-control'}),
            'zipcode': forms.NumberInput(attrs={'class': 'form-control'}),
        }