#include <iostream>
using namespace std;

class Distance
{
    protected:
    double kms,meters;
}; 
class School:private Distance
{
    string school_name,address;
    double distance;
    public:
    School()
    {
        cout<<"Enter School Name and Address: "<<endl;
        cin>>school_name>>address;
        cout<<"Enter Distance from home(km & m seperate by space):"<<endl;
        cin>>kms>>meters;
        distance = kms+(meters/1000);
    }
    ~School()
    {
        cout<<endl<<"School Name: "<<school_name<<endl<<"Address: "<<address<<endl<<"Distance from home: "<<distance<<endl;
    }
};
class Office:private Distance
{
    string office_name,address;
    double distance;
    public:
    Office()
    {
        cout<<"Enter Office Name and Address: "<<endl;
        cin>>office_name>>address;
        cout<<"Enter Distance from home(km & meters seperate by space):"<<endl;
        cin>>kms>>meters;
        distance = kms+(meters/1000);
    }
    ~Office()
    {
        cout<<endl<<"Office Name: "<<office_name<<endl<<"Address: "<<address<<endl<<"Distance from home: "<<distance<<endl;
    }
};
int main()
{
    School sch;
    Office off;
    return 0;
}