//Write a program to input any number after that find factorial number.
#include <iostream>
using namespace std;

double factorial(int n)
{
    if(n==1)
    return 1;
    else
    return n*factorial(n-1);
}
int main()
{
    int num;
    cout<<"Enter a number: "<<endl;
    cin>>num;
    cout<<"Factorial of "<<num<<": "<<factorial(num)<<endl;
    return 0;
}
