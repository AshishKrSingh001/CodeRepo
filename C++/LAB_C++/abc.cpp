#include <iostream>
using namespace std;
class A
{
    public:
    static int b;
    int c;
    void incre()
    {
        b++;
        c++;
    }
    void output();
};

inline void A::output()
{
    cout<<"Value of b: "<<b<<endl<<"Value of c: "<<c<<endl;
    cout<<"Address of b: "<<&b<<endl<<"Address of c: "<<&c<<endl;
}int A::b;
int main()
{
	
    A a;
    a.incre();
    a.output();

    A b;
    b.incre();
    b.output();

    A c;
    c.incre();
    c.output();

    return 0;
}
