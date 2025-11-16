#include <iostream>
using namespace std;

class Student
{
    protected:
    int id;
    string name;
    float marks;
    public:
    float percentage;
    Student()
    {
        cout<<"Enter ID, NAME and total MARKS in 5 subject of student: "<<endl;
        cin>>id>>name>>marks;
        percentage = marks/5;
    }
};
class Topper:public Student
{
    public:
    static int i;
    void show()
    {
        i++;
        cout<<i<<". ID: "<<id<<"\t Name: "<<name<<endl;
    }
};
int main()
{
    Topper t[5];
    for(int i=0;i<3;i++)
    {
        t[i].show();
    }
    return 0;
}