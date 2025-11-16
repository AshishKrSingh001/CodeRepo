#include <iostream>
using namespace std;

class Employee
{
    protected:
        int Id;
        string post,name,mobNo;
        float salary;
        static int count;
    public:
        void input()
        {
            count++;
            cout<<"Enter Employee_"<<count<<" ID, NAME, POST, MOB_NO, SALARY(respectively):"<<endl;
            cin>>Id>>name>>post>>mobNo>>salary;
        }
};int Employee::count;
class Details:public Employee
{
    public:
    ~Details()
    {
        cout<<endl<<"Employee_"<<count<<" Details"<<endl<<"ID: "<<Id<<endl<<"NAME: "<<name<<endl<<"POST: "<<post<<endl<<"MOB_NO: "<<mobNo<<endl<<"SALARY: "<<salary<<endl;
    }
};
int main()
{
    Details a[5];
    for(int i=0;i<5;i++)
    {
        a[i].input();
    }
    return 0;
}