// Write a program to multiply two matrices if multiplication is possible.
#include <iostream>
using namespace std;
template<typename T>class Array
{
    public:
    void input(T *a,int n)
    {
        cout<<"Enter row/column of Square Matrix: "<<endl;
        cin>>n;
        cout<<"Enter "<<n*n<<" element of Square Matrix: "<<endl;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                cin>>*(a+i*n+j);
            }
        }
    }
    void output(T *a,int n)
    {
        cout<<"Element of Square Matrix: "<<endl;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                cout<<*(a+i*n+j)<<"\t";
            }
            cout<<endl;
        }
        
    }
    void multi_of_matrix(T *multi,T *a,T *b,int n)
    {
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                *(multi+i*n+j)=0;
                for(int k=0;k<n;k++)
                {
                    *(multi+i*n+j)+=*(a+i*n+k)**(b+k*n+j);
                }
            }
        }
    }
};
int main()
{
    int *arr1,*arr2,n,*multi;
    Array <int> obj;
    obj.input(arr1,n);
    obj.input(arr2,n);
    obj.output(arr1,n);
    obj.output(arr2,n);
    obj.multi_of_matrix(multi,arr1,arr2,n);
    obj.output(multi,n);

    return 0;
}
