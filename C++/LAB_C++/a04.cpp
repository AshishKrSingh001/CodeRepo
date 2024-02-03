// Write a program to input any number after that check number is Armstrong or not
#include <iostream>
#include <math.h>
using namespace std;

int armstrong(int num)
{
    int n,arm=0,num1=num;
    for(n=0;num>0;num/=10,n++);
    while(num1>0)
    {
        int d=num1%10;
        arm=arm+pow(d,n);
        num1/=10;
    }
    return arm;
}

int main()
{
    int num;
    cout<<"Enter a number: "<<endl;
    cin>>num;
    if(armstrong(num)==num)
    {
        cout<<"Armstrong"<<endl;
    }
    else
    {
        cout<<"Not Armstrong"<<endl;
    }
    return 0;
}
