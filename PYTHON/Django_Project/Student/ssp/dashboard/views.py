from django.shortcuts import redirect, render
from . models import *
from . forms import *
from django.contrib import messages
from django.views import generic
from . import views
from youtubesearchpython import VideosSearch
import requests
import wikipedia

# Create your views here.
def home(request):
    return render(request,"dashboard/home.html")

def notes(request):
    if request.method=="POST":
        form =NotesForm(request.POST)
        if form.is_valid():
            notes = Notes(user = request.user,title = request.POST['title'],description = request.POST['description'])
            notes.save()
        messages.success(request,f"notes added by {request.user.username} successfully!")
    else:
        form = NotesForm()
    notes = Notes.objects.filter(user = request.user)
    return render(request,"dashboard/notes.html",locals())

def delete_note(request,pk=None):
    Notes.objects.get(id=pk).delete()
    messages.success(request,f"notes deleted by {request.user.username} successfully!")
    return redirect("notes")
class NotesDetailView(generic.DetailView):
    model = Notes

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
                finished=False
            homeworks = Homework(
                user = request.user,
                subject = request.POST['subject'],
                title = request.POST['title'],
                description = request.POST['description'],
                due = request.POST['due'],
                is_finished = finished
            )
            homeworks.save()
            messages.success(request,f"Homework added by {request.user.username} successfully!")
        else:
            form = HomeworkForm()
    homeworks = Homework.objects.filter(user = request.user)
    if len(homeworks)==0:
        homework_done = True
    else:
        homework_done = False
    return render(request,'dashboard/homework.html',locals())

def update_homework(request,pk=None):
    homework = Homework.objects.get(id=pk) 
    if homework.is_finished == True:
        homework.is_finished = False
    else:
        homework.is_finished = True
    homework.save()
    messages.success(request,f"homework updated by {request.user.username} successfully!")
    return redirect('homework')

def delete_homework(request,pk=None):
    Homework.objects.get(id=pk).delete()
    messages.success(request,f"homework deleted by {request.user.username} successfully!")
    return redirect("homework")

def youtube(request):
    if request.method == "POST":
        form = DashboardForm(request.POST)
        text = request.POST['text']
        video = VideosSearch(text,limit=10)
        result_list = []
        for i in video.result()['result']:
            result_dict = {
                'input':text,
                'title':i['title'],
                'duration':i['duration'],
                'thumbnails':i['thumbnails'][0]['url'],
                'channel':i['channel']['name'],
                'link':i['link'],
                'views':i['viewCount']['short'],
                'published':i['publishedTime'],
            }
            desc = ""
            if i['descriptionSnippet']:
                for j in i['descriptionSnippet']:
                    desc += j['text']
            result_dict['description']=desc
            result_list.append(result_dict)
        return render(request,"dashboard/youtube.html",locals())
    else:
        form = DashboardForm()
    return render(request,"dashboard/youtube.html",locals())

def todo(request):
    if request.method == "POST":
        form = TodoForm(request.POST)
        if form.is_valid():
            try:
               finished = request.POST['is_finished']
               if finished == 'on':
                   finished = True 
               else:
                   finished = False
            except:
                finished=False
            todos = Todo(
                user = request.user,
                title = request.POST['title'],
                is_finished = finished
            )
            todos.save()
            messages.success(request,f"Todo added by {request.user.username} successfully!")
        else:
            form = TodoForm()
    todos = Todo.objects.filter(user = request.user)
    if len(todos)==0:
        todo_done = True
    else:
        todo_done = False
    return render(request,"dashboard/todo.html",locals())

def update_todo(request,pk):
    todo = Todo.objects.get(id=pk)
    if todo.is_finished == True:
        todo.is_finished = False
    else:
        todo.is_finished = True
    todo.save()
    messages.success(request,f"todo updated by {request.user.username} successfully!")
    return redirect("todo")

def delete_todo(request,pk):
    todo = Todo.objects.get(id=pk).delete()
    messages.success(request,f"todo deleted by {request.user.username} successfully!")
    return redirect("todo")

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
                'title':answer['items'][i]['volumeInfo']['title'],
                'subtitle':answer['items'][i]['volumeInfo'].get('subtitle'),
                'description':answer['items'][i]['volumeInfo'].get('description'),
                'count':answer['items'][i]['volumeInfo'].get('pageCount'),
                'categories':answer['items'][i]['volumeInfo'].get('categories'),
                'rating':answer['items'][i]['volumeInfo'].get('pageRating'),
                'thumbnail':answer['items'][i]['volumeInfo'].get('imageLinks').get('thumbnail'),
                'preview':answer['items'][i]['volumeInfo'].get('previewLink')
            }
            result_list.append(result_dict)
        return render(request,"dashboard/books.html",locals())
    else:
        form = DashboardForm()
    return render(request,"dashboard/books.html",locals())

def dictionary(request):
    if request.method == "POST":
        form = DashboardForm(request.POST)
        text = request.POST['text']
        url = f"https://api.dictionaryapi.dev/api/v2/entries/en_US/{text}"
        r = requests.get(url)
        answer = r.json()
        print(answer)
        try:
            phonetics = answer[0]['phonetics'][0].get('text', 'N/A')
            audio = answer[0]['phonetics'][0].get('audio', 'N/A')
            definition = answer[0]['meanings'][0]['definitions'][0].get('definition', 'N/A')
            example = answer[0]['meanings'][0]['definitions'][0].get('example', 'N/A')
            synonyms_list = answer[0]['meanings'][0]['definitions'][0].get('synonyms', [])
            synonyms = ", ".join(synonyms_list)
        except:
            pass
        return render(request,"dashboard/dictionary.html",locals())
    else:
        form = DashboardForm()
    return render(request,"dashboard/dictionary.html",locals())

def wiki(request):
    if request.method=="POST":
        text = request.POST['text']
        form = DashboardForm()
        search = wikipedia.page(text)
        title = search.title
        links = search.url
        details = search.summary
        return render(request,"dashboard/wiki.html",locals())
    form = DashboardForm()
    return render(request,"dashboard/wiki.html",locals())