//Write a program to find the roots of the quadratic equation ax2+ bx + c = 0.
#include <iostream>
#include <math.h>
using namespace std;
int main()
{
    double a,b,c;
    cout<<"Enter Three coefficient respectively: "<<endl;
    cin>>a;
    cin>>b;
    cin>>c; 
    double root1=(-b+sqrt(pow(b,2)-(4*a*c)))/(2*a);
    double root2=(-b-sqrt(pow(b,2)-(4*a*c)))/(2*a);
    cout<<"Root 1: "<<root1<<endl<<"Root 2: "<<root2<<endl;
}