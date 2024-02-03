// Write a program to calculate the compound interest using the formula A = P × (1 + r/100)n.
#include <iostream>
#include <math.h>
using namespace std;
class CompoundInterest
{
    private:
    double A,P,r,n;
    public:
    CompoundInterest()
    {
        cout<<"Enter Principle amount, rate and time(respectively): "<<endl;
        cin>>P>>r>>n;
    }
    ~CompoundInterest()
    {
        A= P*pow((1+(r/100)),n);
        cout<<"Compound interest is: "<<A<<endl;
    }
};
int main()
{
    CompoundInterest ci;
    return 0;
}