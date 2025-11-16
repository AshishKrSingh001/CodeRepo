//  Write a program to check whether the given matrix is orthogonal or not. Use
// the formula A × AT = I
#include <iostream>
using namespace std;
template<typename T>class Array
{
    private:
    T *a;
    int n;
    public:
    Array()
    {
        a = new T[n];
    }
    void input()
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
    void output()
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
    bool multi_of_matrix()
    {
        T *multi;
        multi = new T[n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                *(multi+i*n+j)=0;
                for(int k=0;k<n;k++)
                {
                    *(multi+i*n+j)+=*(a+i*n+k)**(a+k*n+j);
                }
            }
        }
        int count1=0,count2=0;
		for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i==j)
                {
                    if(*(multi+i*n+j)==1)
                    count1++;
                }
                else
                {
                    if(*(multi+i*n+j)==0)
                    count2++;
                }

            }
        }
        if(count1==n && count2==(n*n-n))
        return true;
        else
        return false;
    }
    void display()
    {
        if(multi_of_matrix())
        cout<<"It is Orthogonal"<<endl;
        else
        cout<<"Not orthogonal"<<endl;
    }
    ~Array()
    {
        delete a;
    }
};
int main()
{
    Array<int> a;
    a.input();
    a.output();
    a.display();
    return 0;
}