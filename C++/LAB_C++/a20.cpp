//  Write a program to find the number of duplicate elements and remove the
// duplicate elements from the list
#include <iostream>
using namespace std;
template<typename T>class Array
{
    private:
    T *arr;
    int n;
    public:
    Array()
    {
        arr=new T[n];
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
    void del(T index)
    {
        for(int i=index;i<n;i++)
        {
            *(arr+i)=*(arr+i+1);
			n--;
        }
    }
    void remove()
    {
        for(int i=0;i<n-1;i++)
        {
            for(int j=i;j<n;j++)
            {
                if(*(arr+i)==*(arr+j))
                {
                    del(i);
                }
            }
        }
    }
    ~Array()
    {
        delete arr;
    }
};


int main()
{
    Array<int> a;
    a.input();
    a.output();
    a.remove();
    a.output();
    return 0;
}
