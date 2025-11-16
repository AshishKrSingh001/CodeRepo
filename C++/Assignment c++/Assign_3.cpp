#include <iostream>
using namespace std;

class Employee
{
    protected:
        int empno;
        string name,post;
        public:
        Employee()
        {
            cout<<"Enter Employee's ID, NAME and POST:"<<endl;
            cin>>empno>>name>>post;
        }
};
class Qualification:public Employee
{
    protected:
        float UG,PG;
        int exprience;
    public:
        Qualification()
        {
            cout<<"Enter UG percentage, PG percentage and experience years:"<<endl;
            cin>>UG>>PG>>exprience;
        }
};
class Salary:public Qualification
{
    private:
    double b_sal;
    public:
    Salary()
    {
        cout<<"Enter your Basic Salary:"<<endl;
        cin>>b_sal;
        if((UG>=90 && UG<=100)||(PG>=90 && PG<=100)||(exprience>=5))
        {
            b_sal = b_sal*(140/100);
        }
        if((UG>=80 && UG<90)||(PG>=80 && PG<90)||(exprience>=3 && exprience<5))
        {
            b_sal = b_sal*(130/100);
        }
        if((UG>=70 && UG<80)||(PG>=70 && PG<80)||(exprience>=2 && exprience<3))
        {
            b_sal = b_sal*(120/100);
        }
        if((UG>=60 && UG<70)||(PG>=60 && PG<70)||(exprience>=1 && exprience<2))
        {
            b_sal = b_sal*(110/100);
        }
    }
    ~Salary()
    {
        cout<<"Employee Detalis"<<endl<<"ID: "<<empno<<endl<<"Name: "<<name<<endl<<"UG percentage: "<<UG<<endl<<"PG percentage: "<<PG<<endl<<"Experience: "<<exprience<<endl<<"Salary: "<<b_sal<<endl;
    }
};
int main()
{
    Salary obj;
    return 0;
}