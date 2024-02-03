#include <iostream>
using namespace std;
class Date
{
    public:
    int dd,mm,yyyy;
    Date()
    {
        cout<<"Enter date,month and year seperated by space: "<<endl;
        cin>>dd>>mm>>yyyy;
    }
};
class Employee
{
    private:
    string name,post;
    int id;
    
    
    public:
    Employee()
    {
        cout<<"Enter Employee's name, id, and post: "<<endl;
        cin>>name>>id>>post;
    }
    ~Employee()
    {
        cout<<"Enter date of birth:"<<endl;
        Date DOB;
        cout<<"Enter date of hiring:"<<endl;
        Date Date_of_hiring;
        cout<<"Employee's details: "<<endl<<"Name: "<<name<<endl<<"Id: "<<id<<endl<<"Post: "<<post<<endl<<"DOB: "<<DOB.dd<<"-"<<DOB.mm<<"-"<<DOB.yyyy<<endl;
    }
};
int main()
{
    Employee emp;
    return 0;
}