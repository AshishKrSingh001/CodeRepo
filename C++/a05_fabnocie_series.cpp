#include <iostream>
using namespace std;
int main()
{
    int num1,num2,num3,i;
    cout<<"Enter two number:\n";
    cin>>num1>>num2;
    cout<<num1;
    for(i=0;i<5;i++)
    {   
        num3=num1;
        num1=num2;
        num2=num3+num2;
        
        cout<<"\t"<<num1<<"\t";

    }
    return 0;
}