//  Write a program for ex=1+x+x2+x3+x4+∙∙∙+xn using function with parameters
// and return type.
#include <iostream>
#include <math.h>
using namespace std;
double binomial(double X,int n)
{
    int num=0;
    for(int i=0;i<n;i++)
    {
        num=num+pow(X,i);
    }
    return num;
}
int main()
{
    double num,n;
    cout<<"Enter value of X & n"<<endl;
    cin>>num>>n;
    cout<<"1+x+x2+x3+x4+_+xn: "<<binomial(num,n)<<endl;
    return 0;
}