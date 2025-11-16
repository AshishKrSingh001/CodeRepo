//  Write a program to search an element in the given two-dimensional array
// using function
#include <iostream>
using namespace std;
template <class T>
void Array_input(T *a,int n)
{
    cout<<"Enter "<<n<<" Array element: "<<endl;
    for(int i=0i;<n;i++)
    for(int j=0;j<n;j++)
    cin>>a[i];
}
template <class T>
void Array_output(T *a,int n)
{
    cout<<" Array element: "<<endl;
    for(int i=0;i<n;i++)
    for(int j=0;j<n;j++)
    cout<<a[i]<<"\t";
    cout<<endl;
}
template <class
