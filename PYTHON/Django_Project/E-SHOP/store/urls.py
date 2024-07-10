from django.urls import path
from eshop import settings
from store import views
from django.conf.urls.static import static
from .views.login import Signin
from .views.signup import Signup
from .views.login import logout
from .views.cart import Cart

from .views.home import Home

urlpatterns = [
   path('',Home.as_view(),name="home"),
   path('cart/',Cart.as_view(),name="cart"),
   path('signup/', Signup.as_view(), name='signup'),
   path('login/',Signin.as_view(),name="login"),
   path('logout/',logout,name="logout"),
]+ static(settings.MEDIA_URL,document_root=settings.MEDIA_ROOT)
