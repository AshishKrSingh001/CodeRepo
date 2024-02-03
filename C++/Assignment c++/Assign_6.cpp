#include <iostream>
#include <math.h>
#define PI  3.14
using namespace std;

class Shape
{
    protected:
    float r,h;
    public:
    Shape()
    {
        cout<<"Enter Radius and Height: "<<endl;
        cin>>r>>h;
    }
};
class Area:public Shape
{
    private:
    double AreaOfCircle,AreaOfCone;
    public:
    Area()
    {
        AreaOfCircle = PI*r*r;
        AreaOfCone = PI*r*(r+sqrt((r*r)+(h*h)));
    }
    ~Area()
    {
        cout<<"Area of Circle: "<<AreaOfCircle<<endl<<"Area of Cone: "<<AreaOfCone<<endl;
    }
};
int main()
{
    Area a;
    return 0;
}