// Write a program to concatenate two given strings.
#include <iostream>
using namespace std;
void strconcate(char str1[],char str2[])
{
    int len,i,j;
    char s[50];
    for(i=0;str1[i]!='\0';i++)
    {
        s[i]=str1[i];
    }
    len=i;
    for(i=len,j=0;str2[j]!='\0';i++,j++)
    {
        s[i]=str2[j];
    }
    for(i=0;s[i]!='\0';i++)
    {
        str1[i]=s[i];
    }
}
int main()
{
    char str1[50]="Ashish",str2[50]="Kumar";
    cout<<"String 1: "<<str1<<endl<<"String 2: "<<str2<<endl;
    strconcate(str1,str2);
    cout<<"Concated string: "<<str1<<endl;

    return 0;
}