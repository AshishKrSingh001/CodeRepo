#include <iostream>
using namespace std;

class test
{
    private:
        int x;
    public:
        void getdata(int a)
        {
            x=a;
        }
        void show()
        {
            cout<<"Number: "<<x<<endl;
        }
        friend void operator -(test &z);
        friend void operator --(test &z);
        friend void operator ++(test &z);
        friend test operator --(test &z,int);
        friend test operator ++(test &z,int);
        friend test operator +(test &y,test &z);
        friend test operator -(test &y,test &z);
        friend test operator *(test &y,test &z);
        friend test operator /(test &y,test &z);
        friend bool operator <=(test &y,test &z);
        friend bool operator >=(test &y,test &z);
        friend bool operator <(test &y,test &z);
        friend bool operator >(test &y,test &z);
        friend bool operator !=(test &y,test &z);
};

void operator -(test &z)
{
    z.x = -z.x;
}
void operator --(test &z)
{
    --z.x;
}
void operator ++(test &z)
{
    ++z.x;
}
test operator --(test &z,int)
{
    test t;
    t.x=z.x--;
    return t;
}
test operator ++(test &z,int)
{
    test t;
    t.x=z.x++;
    return t;
}
test operator +(test &y,test &z)
{
    test t;
    t.x = y.x + z.x;
    return t;
}
test operator -(test &y,test &z)
{
    test t;
    t.x = y.x - z.x;
    return t;
}
test operator *(test &y,test &z)
{
    test t;
    t.x = y.x * z.x;
    return t;
}
test operator /(test &y,test &z)
{
    test t;
    t.x = y.x / z.x;
    return t;
}
bool operator <=(test &y,test &z)
{
    return (y.x<=z.x);
}
bool operator >=(test &y,test &z)
{
    return (y.x>=z.x);
}
bool operator <(test &y,test &z)
{
    return (y.x<z.x);
}
bool operator >(test &y,test &z)
{
    return (y.x>z.x);
}
bool operator !=(test &y,test &z)
{
    return (y.x!=z.x);
}



int main()
{
    test a,b,c;
    a.getdata(10);
    b.getdata(20);
     a.show();
     b.show();
    cout<<"a>=b: ";
    if(a>=b)
    {
       cout<<"True"<<endl;
    }
    else
    {
        cout<<"False"<<endl;
    }
    cout<<"a<=b: ";
    if(a<=b)
    {
       cout<<"True"<<endl;
    }
    else
    {
        cout<<"False"<<endl;
    }
    cout<<"a>b: ";
    if(a>b)
    {
       cout<<"True"<<endl;
    }
    else
    {
        cout<<"False"<<endl;
    }
    cout<<"a<b: ";
    if(a<b)
    {
       cout<<"True"<<endl;
    }
    else
    {
        cout<<"False"<<endl;
    }
    cout<<"a!=b: ";
    if(a!=b)
    {
       cout<<"True"<<endl;
    }
    else
    {
        cout<<"False"<<endl;
    }
     cout<<"Addition: "<<endl;
     c=a+b;c.show();
     cout<<"Subtraction: "<<endl;
     c=a-b;c.show();
     cout<<"Multiplication: "<<endl;
     c=a*b;c.show();
     cout<<"Division: "<<endl;
     c=a/b;c.show();
     cout<<"prefix Increment of a: "<<endl;
     ++a;a.show();
     cout<<"prefix Increment of b: "<<endl;
     ++b;b.show();
     cout<<"prefix Decrement of a: "<<endl;
     --a;a.show();
     cout<<"prefix Decrement of b: "<<endl;
     --b;b.show();
     cout<<"postfix Increment of a: "<<endl;
     c=a++;c.show();
     cout<<"postfix Increment of b: "<<endl;
     c=b++;c.show();
     cout<<"postfix Decrement of a: "<<endl;
     c=a--;c.show();
     cout<<"postfix Decrement of b: "<<endl;
     c=b--;c.show();
     cout<<"Negative of a: "<<endl;
     -a;a.show();
     cout<<"Negative of b: "<<endl;
     -b;b.show();
    


    return 0;
}
