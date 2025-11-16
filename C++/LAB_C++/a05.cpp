// Write a program to find nCr using function with parameter and return value
#include <iostream>
using namespace std;
class Combination
{
    private:
    int n,r;
    public:
    Combination(int n,int r)
    {
        this->n=n;
        this->r=r;
    }
    ~Combination()
    {
        int ncr=fact(n)/(fact(n-r)*fact(r));
        cout<<n<<"C"<<r<<": "<<ncr<<endl;
    }
    int fact(int num)
    {
    if(num==1)
    return 1;
    else
    return num*fact(num-1);    
    }
};

int main()
{
    int n,r;
    cout<<"Enter n & r to calculate nCr: "<<endl;
    cin>>n>>r;
    Combination com(n,r);
    return 0;
}