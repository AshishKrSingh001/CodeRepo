/*
    Write a program to apply arithmetic operators to two given values and display
    the result using function with parameters
*/
#include <iostream>
using namespace std;
void input(int &a,int &b)
{
    cout<<"Enter two number: "<<endl;
    cin>>a>>b;
}
double add(double a,double b)
{
    return a+b;
}
double sub(double a,double b)
{
    return a-b;
}
double mult(double a,double b)
{
    return a*b;
}
double divi(double a,double b)
{
    return a/b;
}
int mod(int a,int b)
{
    int c=a%b;
    return c;
}
void result(int a,int b)
{
    cout<<"Addition: "<<add(a,b)<<endl;
    cout<<"Subtraction: "<<sub(a,b)<<endl;
    cout<<"Multiplication: "<<mult(a,b)<<endl;
    cout<<"Division: "<<divi(a,b)<<endl;
    cout<<"Modulus: "<<mod(a,b)<<endl;

}
int main()
{
    int a,b;
    input(a,b);
    result(a,b);
    return 0;
}