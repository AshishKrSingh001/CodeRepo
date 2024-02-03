#include <iostream>
using namespace std;

class Employee
{
    protected:
    string name;
    int id;
};
class Manager:private Employee
{
    private:
    double sal;
    string supervisior;
    int no_of_juniors;
    public:
    Manager()
    {
        cout<<"Enter Manager's name and Id and salary: "<<endl;
        cin>>name>>id;
        cout<<"Enter no of employee working under the manager and name of supervisior: "<<endl;
        cin>>no_of_juniors>>supervisior;
    }
    ~Manager()
    {
        cout<<endl<<"Manager's Details: "<<endl<<"Name: "<<name<<endl<<"Id: "<<id<<endl<<"Salary: "<<sal<<endl<<"No of Employee: "<<no_of_juniors<<endl<<"Supervisior name: "<<supervisior<<endl;
    }
};
int main()
{
    Manager m;
    return 0;
}