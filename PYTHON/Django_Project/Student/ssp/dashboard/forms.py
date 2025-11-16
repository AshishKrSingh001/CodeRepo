from django import forms
from . models import *
from django.contrib.auth.forms import UserCreationForm
from django.contrib.auth.forms import AuthenticationForm

class CustomAuthenticationForm(AuthenticationForm):
    def __init__(self, *args, **kwargs):
        super(CustomAuthenticationForm, self).__init__(*args, **kwargs)
        self.fields['username'].widget.attrs.update({'class': 'form-control'})
        self.fields['password'].widget.attrs.update({'class': 'form-control'})

class UserRegistrationForm(UserCreationForm):
    username = forms.CharField(widget=forms.TextInput(attrs={'autofocus':'True','class':'form-control'}))
    password1 = forms.CharField(label='Password',widget=forms.PasswordInput(attrs={'class':'form-control','id': 'password'}))
    password2 = forms.CharField(label='Confirm Password',widget=forms.PasswordInput(attrs={'class':'form-control','id': 'password'}))
    class Meta:
        model = User
        fields = ['username','password1','password2']

class NotesForm(forms.ModelForm):
    class Meta:
        model = Notes
        fields = ['title','description'] 
        widgets = {
            'title':forms.TextInput(attrs={'class':'form-control'}),
            'description':forms.Textarea(attrs={'class':'form-control'}),
        }
class DateInput(forms.DateInput):
    input_type = 'date'
class HomeworkForm(forms.ModelForm):
    class Meta:
        model = Homework
        widgets = {
            'subject':forms.TextInput(attrs={'class':'form-control'}),
            'title':forms.TextInput(attrs={'class':'form-control'}),
            'description':forms.Textarea(attrs={'class':'form-control'}),
            'due':DateInput(attrs={'class':'form-control'}),
            'is_finished': forms.CheckboxInput(attrs={'class': 'btn-check mt-4'}),
        }
        fields = ['subject','title','description','due','is_finished']

class DashboardForm(forms.Form):
    text = forms.CharField(max_length=100,label="Enter your Search",
        widget=forms.TextInput(attrs={'class': 'form-control'}))
    
class TodoForm(forms.ModelForm):
    class Meta:
        model = Todo
        fields = ['title','is_finished']
        widgets = {
            'title':forms.TextInput(attrs={'class':'form-control'}),
            'is_finished': forms.CheckboxInput(attrs={'class': 'btn-check mt-4'}),
        }

class ConversionForm(forms.Form):
    CHOICES = [('length','Length'),('mass','Mass')]
    measurement = forms.ChoiceField(choices = CHOICES,widget=forms.RadioSelect)

class ConversionLengthForm(forms.Form):
    CHOICES = [('yard','Yard'),('foot','Foot')]
    input = forms.CharField(required=False,label=False,widget=forms.TextInput(attrs={'type':'number','placeholder':'Enter the Number','class':'form-control'}))
    measure1 = forms.CharField(label='',widget=forms.Select(choices=CHOICES,attrs={'class':'form-control'}))
    measure2 = forms.CharField(label='',widget=forms.Select(choices=CHOICES,attrs={'class':'form-control'}))

class ConversionMassForm(forms.Form):
    CHOICES = [('pound','Pound'),('kilogram','Kilogram')]
    input = forms.CharField(required=False,label=False,widget=forms.TextInput(attrs={'type':'number','placeholder':'Enter the Number','class':'form-control'}))
    measure1 = forms.CharField(label='',widget=forms.Select(choices=CHOICES,attrs={'class':'form-control'}))
    measure2 = forms.CharField(label='',widget=forms.Select(choices=CHOICES,attrs={'class':'form-control'}))