from django.urls import path
from eshop import settings
from store import views
from django.conf.urls.static import static

from store.middlewares.auth import auth_middleware
from store.views.orders import Order
from .views.login import Signin
from .views.signup import Signup
from .views.login import logout
from .views.cart import Cart
from .views.checkout import Checkout

from .views.home import Home

urlpatterns = [
   path('',Home.as_view(),name="home"),
   path('cart/',Cart.as_view(),name="cart"),
   path('checkout/',auth_middleware(Checkout.as_view()),name="checkout"),
   #path('orders/',Order.as_view(),name="orders"),
   path('orders/',auth_middleware(Order.as_view()),name="orders"),
   path('signup/', Signup.as_view(), name='signup'),
   path('login/',Signin.as_view(),name="login"),
   path('logout/',logout,name="logout"),
]+ static(settings.MEDIA_URL,document_root=settings.MEDIA_ROOT)
