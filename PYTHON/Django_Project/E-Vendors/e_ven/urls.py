"""
URL configuration for e_ven project.

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/5.0/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.urls import path, include
from django.conf import settings
from django.conf.urls.static import static
from django.contrib.auth import views as auth_views
from app.forms import LoginForm

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include("app.urls")),
    path("account/login/",auth_views.LoginView.as_view(template_name="app/login.html",authentication_form=LoginForm,redirect_authenticated_user=True),name="login"),
    path('logout/', auth_views.LogoutView.as_view(next_page='login'), name='logout'),
]+static(settings.MEDIA_URL,document_root=settings.MEDIA_ROOT)
 

admin.site.site_header = "bundelicrafts.com"
admin.site.site_title = "bundelicrafts.com"
admin.site.site_index_title = "Welcome to bundelicrafts.com"