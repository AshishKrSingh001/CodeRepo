#include <iostream>
using namespace std;
int main()
{
    int num1,num2,fnum1=1,fnum2=1,i,j;
    cout<<"Enter two number:"<<endl;
    cin>>num1>>num2;
    for(i=1;i<=num1;i++)
    {
        fnum1=fnum1*i;
    }
    for(i=1;i<=num1;i++)
    {
        fnum2=fnum1*i;
    }
    if(fnum1==num2 && fnum2==num1)
    {
        cout<<"Amilcable";
    }
    else
    {
        cout<<"Not Amicable";
    }

    return 0;
}