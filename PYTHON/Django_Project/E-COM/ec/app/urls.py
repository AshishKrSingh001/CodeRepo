from django.urls import path
from . import views
from django.conf import settings
from django.conf.urls.static import static
from django.contrib.auth import views as auth_view
from .forms import LoginForm, MyPasswordResetForm,MyPasswordChangeForm

urlpatterns = [
    path("",views.home,name="home"),
    path("about/",views.about,name="about"),
    path("contact/",views.contact,name="contact"),
    path("category/<slug:val>",views.CategoryView.as_view(),name="category"),
    path("category-title/<val>",views.CategoryTitle.as_view(),name="category-title"),
    path("product-detail/<int:pk>",views.ProductDetail.as_view(),name="product-detail"),
    path('profile/',views.ProfileView.as_view(),name="profile"),
    path('address/',views.address,name="address"),
    path('updateAddress/<int:pk>',views.UpdateAddress.as_view(),name="updateAddress"),

    #login
    path("customer-registration/",views.CustomerRegistrationView.as_view(),name="customer-registration"),
    path("account/login/",auth_view.LoginView.as_view(template_name="app/login.html",authentication_form=LoginForm),name="login"),

    path("password-reset/",auth_view.PasswordResetView.as_view(template_name="app/passwordReset.html",form_class=MyPasswordResetForm),name="password-reset"),

    path("password-change/",auth_view.PasswordChangeView.as_view(template_name="app/changepPassword.html",form_class=MyPasswordChangeForm, success_url="/password-change-done"), name="password-change"),

    path("password-change-done/",auth_view.PasswordChangeDoneView.as_view(template_name="app/passwordChangeDone.html"), name="password-change-done"),
]+static(settings.MEDIA_URL,document_root=settings.MEDIA_ROOT)
 