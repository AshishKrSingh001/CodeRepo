//  Write a program to reverse the string.
#include <iostream>
using namespace std;
void revstr(char str[])
{

    char s[50];
    int i;
    for(i=0;str[i]!='\0';i++);
    for(int j=0,k=i-1;j<i;j++,k--)
    {
        s[k]=str[j];
    }
    for(int j=0;j<i;j++)
    {
        str[j]=s[j];
    }
}
int main()
{
    char str[]="Ashish";
    cout<<"String is: "<<str<<endl;
    revstr(str);
    cout<<"After reverse String is: "<<str<<endl;
    return 0;
}