// Write a program to insert an element at the given position in single-
// dimensional array.
#include <iostream>
using namespace std;
template<typename T>class Array
{
    private:
    T *arr;
    int n;
    public:
    Array(T *a,int n)
    {
        arr=new int[n];
        arr=a;
        this->n=n;
    }
    void input()
    {
        cout<<"Enter size of array: "<<endl;
        cin>>n;
        cout<<"Enter "<<n<<" element of Array: "<<endl;
        for(int i=0;i<n;i++)
        {
            cin>>*(arr+i);
        }
    }
    void output()
    {
        cout<<"Element of Array: "<<endl;
        for(int i=0;i<n;i++)
        {
            cout<<*(arr+i)<<"\t";
        }
        cout<<endl;
    }
    void insert()
    {
        int position;
        T element;
    	cout<<"Enter the position You want to enter an element: "<<endl;
        cin>>position;
        cout<<"Enter the element you want to insert: "<<endl;
        cin>>element;
        if(position<=n)
        {
            for(int i=n;i>=position;i--)
            {
                *(arr+i)=*(arr+i-1);
            }
            *(arr+position-1)=element;
            n++;
        }
        else
        {
            cout<<"Index Out of Bound"<<endl;
        }

    }
    ~Array()
    {
        delete arr;
    }
};


int main()
{
    int *arr,n;
    Array<int> a(arr,n);
    a.input();
    a.output();
    a.insert();
    a.output();
    return 0;
}
