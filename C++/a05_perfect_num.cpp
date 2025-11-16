#include <iostream>
using namespace std;
int main()
{
    int num,i,fnum=0;
    cout<<"Enter a number:";
    cin>>num;
    for(i=1;i<num;i++)
    {
        if(num%i==0)
        fnum=fnum+i;
    }
    if(num==fnum)
    cout<<"Perfect number";
    else
    cout<<"Not Perfect number";
}