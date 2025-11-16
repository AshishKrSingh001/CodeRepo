#include <iostream>
using namespace std;
int main()
{
    //twin prime numbers
    int a,b,i,c1=0,c2=0;
    cout<<"Enter Two Numbers ="<<endl;
    cin>>a>>b;
    if(a-b==2||a-b==-2)
    {
        i=2;
        while (a/2>=i)
        {
            if(a%i==0)
                c1++;
            i++;
        }
        i=2;
        while (b/2>=i)
        {
            if(b%i==0)
                c2++;
            i++;
        }
        if(c1==0 && c2==0)
            cout<<a<<" & "<<b<<" are twin prime numbers.";
        else
            cout<<a<<" & "<<b<<" are not twin prime numbers.";
    }
    else
            cout<<a<<" & "<<b<<" are not twin prime numbers.";
    return 0;
}
