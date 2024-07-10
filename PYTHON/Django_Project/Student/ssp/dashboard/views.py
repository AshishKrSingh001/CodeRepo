from django.shortcuts import redirect, render
from .models import Notes, Homework, Todo
from .forms import NotesForm, HomeworkForm, TodoForm, DashboardForm, ConversionForm, ConversionLengthForm, ConversionMassForm, UserRegistrationForm
from django.contrib import messages
from django.views import generic
from . import views
from youtubesearchpython import VideosSearch
import requests
import wikipedia
from django.contrib.auth.decorators import login_required
from django.utils.decorators import method_decorator

# Create your views here.
def home(request):
    return render(request, "dashboard/home.html")

@login_required
def notes(request):
    if request.method == "POST":
        form = NotesForm(request.POST)
        if form.is_valid():
            notes = Notes(user=request.user, title=request.POST['title'], description=request.POST['description'])
            notes.save()
            messages.success(request, f"Notes added by {request.user.username} successfully!")
            return redirect('notes')  # Redirect to the same view to reset the form
    else:
        form = NotesForm()
    
    notes = Notes.objects.filter(user=request.user)
    return render(request, "dashboard/notes.html", {'form': form, 'notes': notes})

@login_required
def delete_note(request, pk=None):
    Notes.objects.get(id=pk).delete()
    messages.success(request, f"Notes deleted by {request.user.username} successfully!")
    return redirect("notes")

@method_decorator(login_required, name='dispatch')
class NotesDetailView(generic.DetailView):
    model = Notes

@login_required
def homework(request):
    if request.method == "POST":
        form = HomeworkForm(request.POST)
        if form.is_valid():
            try:
                finished = request.POST['is_finished']
                if finished == 'on':
                    finished = True 
                else:
                    finished = False
            except:
                finished = False
            
            homeworks = Homework(
                user=request.user,
                subject=request.POST['subject'],
                title=request.POST['title'],
                description=request.POST['description'],
                due=request.POST['due'],
                is_finished=finished
            )
            homeworks.save()
            messages.success(request, f"Homework added by {request.user.username} successfully!")
            return redirect('homework')  # Redirect to the same view to reset the form
        else:
            form = HomeworkForm()
    
    homeworks = Homework.objects.filter(user=request.user)
    homework_done = not homeworks.exists()
    
    return render(request, 'dashboard/homework.html',locals())

@login_required
def update_homework(request, pk=None):
    homework = Homework.objects.get(id=pk)
    homework.is_finished = not homework.is_finished
    homework.save()
    messages.success(request, f"Homework updated by {request.user.username} successfully!")
    return redirect('homework')

@login_required
def delete_homework(request, pk=None):
    Homework.objects.get(id=pk).delete()
    messages.success(request, f"Homework deleted by {request.user.username} successfully!")
    return redirect("homework")

@login_required
def youtube(request):
    if request.method == "POST":
        form = DashboardForm(request.POST)
        text = request.POST['text']
        video = VideosSearch(text, limit=10)
        result_list = []
        for i in video.result()['result']:
            result_dict = {
                'input': text,
                'title': i['title'],
                'duration': i['duration'],
                'thumbnails': i['thumbnails'][0]['url'],
                'channel': i['channel']['name'],
                'link': i['link'],
                'views': i['viewCount']['short'],
                'published': i['publishedTime'],
            }
            desc = ""
            if i['descriptionSnippet']:
                for j in i['descriptionSnippet']:
                    desc += j['text']
            result_dict['description'] = desc
            result_list.append(result_dict)
        return render(request, "dashboard/youtube.html", {'form': form, 'result_list': result_list})
    else:
        form = DashboardForm()
    return render(request, "dashboard/youtube.html", {'form': form})

@login_required
def todo(request):
    if request.method == "POST":
        form = TodoForm(request.POST)
        if form.is_valid():
            try:
                finished = request.POST.get('is_finished', 'off') == 'on'
            except:
                finished = False
            todos = Todo(
                user=request.user,
                title=request.POST['title'],
                is_finished=finished
            )
            todos.save()
            messages.success(request, f"Todo added by {request.user.username} successfully!")
            return redirect('todo')  # Redirect to the same view to reset the form
    else:
        form = TodoForm()

    todos = Todo.objects.filter(user=request.user)
    todo_done = not todos.exists()
    
    return render(request, "dashboard/todo.html", {'form': form, 'todos': todos, 'todo_done': todo_done})

@login_required
def update_todo(request, pk):
    todo = Todo.objects.get(id=pk)
    todo.is_finished = not todo.is_finished
    todo.save()
    messages.success(request, f"Todo updated by {request.user.username} successfully!")
    return redirect("todo")

@login_required
def delete_todo(request, pk):
    Todo.objects.get(id=pk).delete()
    messages.success(request, f"Todo deleted by {request.user.username} successfully!")
    return redirect("todo")

@login_required
def books(request):
    if request.method == "POST":
        form = DashboardForm(request.POST)
        text = request.POST['text']
        url = f"https://www.googleapis.com/books/v1/volumes?q={text}"
        r = requests.get(url)
        answer = r.json()
        result_list = []
        for i in range(10):
            result_dict = {
                'title': answer['items'][i]['volumeInfo']['title'],
                'subtitle': answer['items'][i]['volumeInfo'].get('subtitle'),
                'description': answer['items'][i]['volumeInfo'].get('description'),
                'count': answer['items'][i]['volumeInfo'].get('pageCount'),
                'categories': answer['items'][i]['volumeInfo'].get('categories'),
                'rating': answer['items'][i]['volumeInfo'].get('pageRating'),
                'thumbnail': answer['items'][i]['volumeInfo'].get('imageLinks', {}).get('thumbnail'),
                'preview': answer['items'][i]['volumeInfo'].get('previewLink')
            }
            result_list.append(result_dict)
        return render(request, "dashboard/books.html", {'form': form, 'result_list': result_list})
    else:
        form = DashboardForm()
    return render(request, "dashboard/books.html", {'form': form})

@login_required
def dictionary(request):
    if request.method == "POST":
        form = DashboardForm(request.POST)
        text = request.POST['text']
        url = f"https://api.dictionaryapi.dev/api/v2/entries/en_US/{text}"
        r = requests.get(url)
        answer = r.json()
        try:
            phonetics = answer[0]['phonetics'][0].get('text', 'N/A')
            audio = answer[0]['phonetics'][0].get('audio', 'N/A')
            definition = answer[0]['meanings'][0]['definitions'][0].get('definition', 'N/A')
            example = answer[0]['meanings'][0]['definitions'][0].get('example', 'N/A')
            synonyms_list = answer[0]['meanings'][0]['definitions'][0].get('synonyms', [])
            synonyms = ", ".join(synonyms_list)
        except:
            phonetics = audio = definition = example = synonyms = 'N/A'
        return render(request, "dashboard/dictionary.html", {'form': form, 'phonetics': phonetics, 'audio': audio, 'definition': definition, 'example': example, 'synonyms': synonyms})
    else:
        form = DashboardForm()
    return render(request, "dashboard/dictionary.html", {'form': form})

@login_required
def wiki(request):
    if request.method == "POST":
        text = request.POST['text']
        form = DashboardForm()
        search = wikipedia.page(text)
        title = search.title
        links = search.url
        details = search.summary
        return render(request, "dashboard/wiki.html", {'form': form, 'title': title, 'links': links, 'details': details})
    form = DashboardForm()
    return render(request, "dashboard/wiki.html", {'form': form})

@login_required
def conversion(request):
    if request.method == 'POST':
        form = ConversionForm(request.POST)
        if form.is_valid():
            measurement = form.cleaned_data['measurement']
            context = {'form': form, 'input': True}
            if measurement == 'length':
                measurement_form = ConversionLengthForm()
                context['m_form'] = measurement_form
                if 'input' in request.POST:
                    first = request.POST['measure1']
                    second = request.POST['measure2']
                    input_value = request.POST['input']
                    answer = ''
                    if input_value and float(input_value) > 0:
                        if first == 'yard' and second == 'foot':
                            answer = f'{input_value} yard = {float(input_value) * 3} foot'
                        elif first == 'foot' and second == 'yard':
                            answer = f'{input_value} foot = {float(input_value) / 3} yard'
                    context['answer'] = answer
            elif measurement == 'mass':
                measurement_form = ConversionMassForm()
                context['m_form'] = measurement_form
                if 'input' in request.POST:
                    first = request.POST['measure1']
                    second = request.POST['measure2']
                    input_value = request.POST['input']
                    answer = ''
                    if input_value and float(input_value) > 0:
                        if first == 'pound' and second == 'kilogram':
                            answer = f'{input_value} pound = {float(input_value) * 0.453592} kilogram'
                        elif first == 'kilogram' and second == 'pound':
                            answer = f'{input_value} kilogram = {float(input_value) * 2.20462} pound'
                    context['answer'] = answer
            return render(request, "dashboard/conversion.html", context)
    else:
        form = ConversionForm()
    return render(request, "dashboard/conversion.html", {'form': form, 'input': False})

def register(request):
    if request.method == "POST":
        form = UserRegistrationForm(request.POST)
        if form.is_valid():
            form.save()
            username = form.cleaned_data.get('username')
            messages.success(request, f"Account created for {username}!!")
            return redirect('login')  # Redirect to login after registration
    else:
        form = UserRegistrationForm()
    return render(request, "dashboard/register.html", {'form': form})

@login_required
def profile(request):
    homeworks = Homework.objects.filter(is_finished=False, user=request.user)
    todos = Todo.objects.filter(is_finished=False, user=request.user)
    homework_done = homeworks.exists()
    todo_done = todos.exists()
    return render(request, "dashboard/profile.html", {'homeworks': homeworks, 'todos': todos, 'homework_done': homework_done, 'todo_done': todo_done})
