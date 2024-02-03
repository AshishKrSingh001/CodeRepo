#include <iostream>
using namespace std;

class Student
{
    protected:
    static int rollNo;
    static string name;
};int Student::rollNo;string Student::name;
//class Result:private Student;

class Result:private Student
{
    private:
    char grade;
    int marks;
    public:
    Result()
    {
        cout<<"Enter Marks: "<<endl;
        cin>>marks;
        if(marks>=0 && marks<=50)
        {
            grade = 'F';
        }
        else if(marks>50 && marks<=60)
        {
            grade = 'D';
        }
        else if(marks>60 && marks<=70)
        {
            grade = 'C';
        }
        else if(marks>70 && marks<=80)
        {
            grade = 'B';
        }
        else if(marks>80 && marks<=100)
        {
            grade = 'A';
        }        
    }
    ~Result()
    {
        cout<<"Marks: "<<marks<<endl<<"Grade: "<<grade<<endl;
    }
    
};

class Fees:private Student
{
    private:
    double fees;
    public:
    Fees()
    {
        cout<<"Enter Name and Roll_no: "<<endl;
        cin>>name>>rollNo;
        cout<<"Enter Your fees: "<<endl;
        cin>>fees;
    }
    void submitFees()
    {
        int x;
        cout<<"Enter submmited amount: "<<endl;
        cin>>x;
        fees = fees - x;
    }
    ~Fees()
    {
        cout<<"Student Details"<<endl<<"Name: "<<name<<endl<<"ROLL_NO: "<<rollNo<<endl<<"Fees: "<<fees<<endl;
    }

};

int main()
{
    Fees f;
    f.submitFees();
    Result r;
    return 0;
}