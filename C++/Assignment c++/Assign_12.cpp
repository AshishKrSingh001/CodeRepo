#include <iostream>
using namespace std;

class Publication
{
    protected:
    string title,l_name;
    int pages;
    double play_time;
    
};
class Book:private Publication
{
    public:
    Book()
    {
        cout<<"Enter Book title and pages of book:"<<endl;
        cin>>title>>pages;
    }
    ~Book()
    {
        cout<<"Book Title: "<<title<<endl<<"No of pages: "<<pages<<endl;
    }
};
class Lecture:private Publication
{
    public:
    Lecture()
    {
        cout<<"Enter Lecture name and play time: "<<endl;
        cin>>l_name>>play_time;
    }
    ~Lecture()
    {
        cout<<"Lecture name"<<l_name<<endl<<"Lecture duration time: "<<play_time<<endl;
    }
};
int main()
{
    Book b;
    Lecture l;
    return 0;
}