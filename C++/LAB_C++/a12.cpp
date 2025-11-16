// Write a program to find the sum of square of first n even natural numbers
// using function without parameter but with return type
#include <iostream>
#include <math.h>
using namespace std;
int n;
double Sum_of_Square_of_num()
{
    double sq=0;
    for(int i=0;i<n*2;i+=2)
    {
        sq=sq+pow(i,2);
    }
    return sq;
}
int main()
{
    cout<<"Enter a +ve number: "<<endl;
    cin>>n;
    cout<<"sum of square of first "<<n<<" even natural numbers: "<<Sum_of_Square_of_num()<<endl;
    return 0;
}