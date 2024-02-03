//  Write a program to calculate the factorial of a given number using recursion
#include <iostream>
using namespace std;
int fact(double num)
{
    if(num==1)
    return 1;
    else
    return num*fact(num-1);    
}
int main()
{
    double num;
    cout<<"Enter a number: "<<endl;
    cin>>num;
    cout<<"Factorial of "<<num<<": "<<fact(num);
    return 0;
}