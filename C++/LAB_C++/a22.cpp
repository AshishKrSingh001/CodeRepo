// Write a program to count the number of characters, number of words in the
// string and to check whether the given string is palindrome or not
#include <iostream>
#include <string.h>
int no_of_char(char str[])
{
    int len=0;
    while(str[len]!='\0')
    {
        len++;
    }
    return len;
}
int no_of_words(char str[])
{
    int i,count=1;
    for(i=0;str[i]!='\0';i++)
    {
        if((str[i]==' ' || str[i]=='\t')&&(str[i+1]!=' ' || str[i+1]!='\t'))
        count++;
    }
    return count;
}
bool checkPalindrome(char str[])
{
    if(strcmp(str,strrev(str))==0)
    return true;
    else
    return false;
}
using namespace std;
int main()
{
    char str[]="Ashish kumar is a good boy";
    char s[]="malayalam";
    cout<<"No of Characters of \""<<str<<"\" is: "<<no_of_char(str)<<endl;
    cout<<"No of Words of \""<<str<<"\" is: "<<no_of_words(str)<<endl;
    if(checkPalindrome(s))
    cout<<s<<" is Palindrome"<<endl;
    else
    cout<<s<<" is not palindrome"<<endl;
    return 0;
}