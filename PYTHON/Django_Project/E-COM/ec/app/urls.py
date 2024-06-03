from django.urls import path
from django.contrib import admin
from . import views
from django.conf import settings
from django.conf.urls.static import static
from django.contrib.auth import views as auth_view
from .forms import LoginForm, MyPasswordResetForm,MyPasswordChangeForm,MySetPasswordForm

urlpatterns = [
    path("",views.home,name="home"),
    path("about/",views.about,name="about"),
    path("category/<slug:val>",views.CategoryView.as_view(),name="category"),
    path("category-title/<val>",views.CategoryTitle.as_view(),name="category-title"),
    path("product-detail/<int:pk>",views.ProductDetail.as_view(),name="product-detail"),
    path('profile/',views.ProfileView.as_view(),name="profile"),
    path('address/',views.address,name="address"),
    path('updateAddress/<int:pk>',views.UpdateAddress.as_view(),name="updateAddress"),
    path('add-to-cart/',views.add_to_cart,name="add-to-cart"),
    path('cart/',views.show_cart,name="showcart"),
    path('checkout/',views.Checkout.as_view(),name="checkout"),
    path('buynow/<int:pk>',views.buynow,name="buynow"),
    path('pluscart/',views.plus_cart,),
    path('minuscart/',views.minus_cart,),
    path('removecart/',views.remove_cart,),
    path('paymentdone/', views.PaymentDone.as_view(), name='paymentdone'),
    path('BuyNowPaymentDone/', views.BuyNowPaymentDone.as_view(), name='BuyNowPaymentDone'),
    path('orders/',views.orders,name='orders'),
    path('pluswishlist/',views.plus_wishlist,),
    path('minuswishlist/',views.minus_wishlist,),
    path('wishlists/',views.wishlists,name="wishlists"),
    path("search/",views.search,name='search'),
    path('add-all-to-cart/', views.add_all_to_cart, name='add-all-to-cart'),


    #login
    path("customer-registration/",views.CustomerRegistrationView.as_view(),name="customer-registration"),
    #path("account/login/",auth_view.LoginView.as_view(template_name="app/login.html",authentication_form=LoginForm,redirect_authenticated_user=True),name="login"),
    
    path("password-change/",auth_view.PasswordChangeView.as_view(template_name="app/changePassword.html",form_class=MyPasswordChangeForm, success_url="/password-change-done"), name="password-change"),

    path("password-change-done/",auth_view.PasswordChangeDoneView.as_view(template_name="app/passwordChangeDone.html"), name="password-change-done"),
    path('logout/', auth_view.LogoutView.as_view(next_page='login'), name='logout'),
    path("password-reset/", auth_view.PasswordResetView.as_view(
        template_name="app/passwordReset.html",
        form_class=MyPasswordResetForm), name="password_reset"),

    path("password-reset/done/", auth_view.PasswordResetDoneView.as_view(
        template_name="app/passwordResetDone.html"), name="password_reset_done"),

    path("password_reset_confirm/<uidb64>/<token>/", auth_view.PasswordResetConfirmView.as_view(
        template_name="app/passwordResetConfirm.html",
        form_class=MySetPasswordForm), name="password_reset_confirm"),

    path("password_reset_complete/", auth_view.PasswordResetCompleteView.as_view(
        template_name="app/passwordResetComplete.html"), name="password_reset_complete"),

#     path("password-reset/",auth_view.PasswordResetView.as_view(template_name="app/passwordReset.html",form_class=MyPasswordResetForm),name="password_reset"),

#     path("password-reset/done/",auth_view.PasswordResetDoneView.as_view(template_name="app/passwordResetDone.html"),name="password_reset_done"),

#    path("password_reset_confirm/<uidb64>/<token>/",auth_view.PasswordResetConfirmView.as_view(template_name="app/passwordResetConfirm.html",form_class=MySetPasswordForm),name="password_reset_confirm"),

#     path("password_reset_complete/",auth_view.PasswordResetCompleteView.as_view(template_name="app/passwordResetComplete.html"),name="password_reset_complete"),
]+static(settings.MEDIA_URL,document_root=settings.MEDIA_ROOT)
 

admin.site.site_header = "Moo Heaven:The Milk Oasis"
admin.site.site_title = "Moo Heaven:The Milk Oasis"
admin.site.site_index_title = "Welcome to Moo Heaven"