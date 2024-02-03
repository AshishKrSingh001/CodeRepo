//  Write a program to find the sum of diagonal elements, upper triangular
// elements and the lower triangular elements.
#include <iostream>
using namespace std;

template<typename T>class  Array
{
    T *a;
    int r,c;
    public:
    Array(T *arr,int r,int c)
    {
    	a=arr;
        this->r=r;
        this->c=c;
        a = new T;
        
    }
    void input()
    {
        cout<<"Enter row/column of Square Matrix: "<<endl;
        cin>>c;
        r=c;
        cout<<"Enter "<<r*c<<" element of Square Matrix: "<<endl;
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                cin>>*(a+i*c+j);
            }
        }
    }
    void output()
    {
        cout<<"Element of Square Matrix: "<<endl;
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                cout<<*(a+i*c+j)<<"\t";
            }
            cout<<endl;
        }
        
    }
    private:
    T F_diagonal()
    {
        T sum=0;
        for(int j=0;j<c;j++)
        {
           sum=sum+*(a+j*c+j);
        }
        return sum;
    }
    T S_diagonal()
    {
        T sum=0;
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                if(i+j==c-1)
                {
                    sum=sum+*(a+i*c+j);
                }
            }
        }
        return sum;
    }
    T T_element()
    {
        T sum=0;
        for(int j=0;j<c;j++)
        {
            sum=sum+*(a+j);
        }
        return sum;
    }
    T B_element()
    {
        T sum=0;
        for(int j=0;j<c;j++)
        {
            sum=sum+*(a+(r-1)*c+j);
        }
        return sum;
    }
    T L_element()
    {
        T sum=0;
        for(int i=0;i<r;i++)
        {
            sum=sum+*(a+i*c);
        }
        return sum;
    }
    T R_element()
    {
        T sum=0;
        for(int i=0;i<r;i++)
        {
            sum=sum+*(a+i*c+(c-1));
        }
        return sum;
    }
    public: 
    void display()
    {
        cout<<"Sum of Top element of matrix: "<<T_element()<<endl;
        cout<<"Sum of Bottom element of matrix: "<<B_element()<<endl;
        cout<<"Sum of Right element of matrix: "<<R_element()<<endl;
        cout<<"Sum of Left element of matrix: "<<L_element()<<endl;
        cout<<"Sum of First diagonal element of matrix: "<<F_diagonal()<<endl;
        cout<<"Sum of Second diagonal element of matrix: "<<S_diagonal()<<endl;
    }
    
    ~Array()
    {
        delete a;
    }
};
int main()
{
    int *a,row,col;
    Array <int> arr(a,row,col);
    arr.input();
    arr.output();
    arr.display();
    return 0;

}
