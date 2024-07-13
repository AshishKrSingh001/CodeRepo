from django.shortcuts import redirect

def auth_middleware(get_response):
    def middleware(request):
        return_url = request.get_full_path()
        if not request.session.get('customer'):
            return redirect(f'/login/?return_url={return_url}')
        response = get_response(request)
        return response
    
    return middleware
