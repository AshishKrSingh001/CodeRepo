// Write a program to search and display the position of an element in a single-
// dimensional array using function.
#include <iostream>
using namespace std;
template<typename T>class  Array
{
    T *a,s;
    int n;
    public:
    Array(T *arr,int n)
    {
    	a=arr;
        this->n=n;
        a = new T[n];
        
    }
    void input()
    {
        cout<<"Enter size of Array: "<<endl;
        cin>>n;
        cout<<"Enter "<<n<<" element of Array: "<<endl;
        for(int i=0;i<n;i++)
        {
            cin>>*(a+i);
        }
    }
    void output()
    {
        cout<<"Element of Array: "<<endl;
        for(int i=0;i<n;i++)
        {
            cout<<*(a+i)<<"\t";
        }
        cout<<endl;
    }
    void search()
    {
        cout<<"Enter searching element: "<<endl;
        cin>>s;
        int i;
        for(i=0;i<n;i++)
        {
            if(*(a+i)==s)
            {
            	cout<<"Found!"<<endl;
            	break;	
			}
        }
        if(i>=n)
        {
            cout<<"Not found!"<<endl;
        }
    } 
    ~Array()
    {
        delete a;
    }
};
int main()
{
    int *a,n;
    Array <int> arr(a,n);
    arr.input();
    arr.output();
    arr.search();
    return 0;

}
