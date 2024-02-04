#include <iostream>
using namespace std;
template <class t>
t sum(t a,t b)
{
    return (a+b);
}
int main()
{
    cout<<sum(10,20)<<endl;
    cout<<sum(10.2,20.3)<<endl;
    cout<<sum(10.2f,20.888f)<<endl;
    cout<<sum('A','1')<<endl;
    return 0;
}