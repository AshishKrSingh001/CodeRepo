from django import forms
from . models import *

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