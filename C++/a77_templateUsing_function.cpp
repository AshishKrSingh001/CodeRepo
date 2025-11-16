#include <iostream>
using namespace std;

class test
{
    private:
        int x;
    public:
        void getdata();
        void show();
        void operator +(test &z);
        

};
void test::getdata()
{
    cout<<"Enter no: "<<endl;
    cin>>x;
}
void test::show()
{
    cout<<"Number: "<<x<<endl;
}
void test::operator +(test &z)
{
    x=x+z.x;
}
int main()
{
    test t,q;
    t.getdata();
    t.show();
    t.getdata();
    t.show();
    t+q;
    t.show();
    return 0;
}