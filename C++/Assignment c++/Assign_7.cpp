#include <iostream>
using namespace std;

class Class_result
{
    protected:
    int test_marks,activities_marks,sports_marks;
    public:
    Class_result()
    {
        cout<<"Enter marks of Tests, Activities, Sports:"<<endl;
        cin>>test_marks>>activities_marks>>sports_marks;
    }
};
class Final_result: public Class_result
{
    protected:
    int Id;
    string name;
    public:
    Final_result()
    {
        cout<<"Enter Name and Id of student: "<<endl;
        cin>>name>>Id;
    }
    ~Final_result()
    {
        cout<<endl<<"Student Details"<<endl<<"Test Marks: "<<test_marks<<endl<<"Activities Marks: "<<activities_marks<<endl<<"Sports Marks: "<<sports_marks<<endl;
    }
};
int main()
{
    Final_result obj;
    return 0;
}
