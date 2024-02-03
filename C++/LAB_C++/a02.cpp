// Write a program to find the largest number among the given list.
#include <iostream>
using namespace std;

template <class t>
void smallest(t *a,int n,t &g)
{
    g=*a;
    for(int i=1;i<n;i++)
    {
        if(g>*(a+i))
        {
            g=*(a+i);
        }
    }
}
template <class t>
void greatest(t *a,int n,t &g)
{
    g=*a;
    for(int i=1;i<n;i++)
    {
        if(g<*(a+i))
        {
            g=*(a+i);   
        }
    }
}
template <class t>
void Input(t *a,int &n)
{
    cout<<"Enter size of array: "<<endl;
    cin>>n;
    cout<<"Enter element of array: "<<endl;
    for(int i=0;i<n;i++)
    {
        cin>>*(a+i);
    }
}
template <class t>
void Output(t *a,int n)
{
    cout<<"Array: "<<endl;
    for(int i=0;i<n;i++)
    {
        cout<<*(a+i)<<"\t";
    }
    cout<<endl;
}
int main()
{
    //double *a=new double;
    //double gt,st;
    int *a = new int;
    int gt,st;
    // float *a = new float;
    //float gt,st;
     //char *a = new char;
     //char gt,st;
    int n;
    Input(a,n);
    Output(a,n);
    greatest(a,n,gt);
    smallest(a,n,st);
    cout<<"Greatest num: "<<gt<<endl;
    cout<<"Smallest num: "<<st<<endl;
    return 0;
}