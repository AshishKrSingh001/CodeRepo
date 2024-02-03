//  Write a program for printing a table of a given number using function with
//  parameter and no return value.
#include <iostream>
using namespace std;
void table(int num)
{
    for(int i=1;i<=10;i++)
    {
        cout<<num<<"X"<<i<<": "<<num*i<<endl;
    }
}
int main()
{
    cout<<"Table: "<<endl;
    table(12);
    return 0;
}