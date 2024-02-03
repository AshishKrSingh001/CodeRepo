// Write a program to find the greatest number amongst three given numbers by
// using function with parameters and return value.
#include <iostream>
using namespace std;
template <class t>
t greatest(t a,t b,t c)
{
    return ((a>b && a>c)?a:(b>c)?b:c);
}
int main()
{
    //int a,b,c;
    // float a,b,c;
     double a,b,c;
    
    //char a,b,c;
    cout<<"Enter three number: "<<endl;
    cin>>a>>b>>c;
     a++;
     ++a;
    cout<<"Greatest number: "<<greatest(a,b,c)<<endl;
    return 0;
}