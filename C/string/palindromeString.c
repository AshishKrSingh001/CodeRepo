#include <stdio.h>
#include <string.h>
void palindromeString(char str[])
{
    int len = 0, i, j;
    for(int i=0;str[i]!='\0';i++)
    {
        len += 1;
    }
    printf("\nLength of String \"%s\" is: %d\n",str,len);
    
    char res[len-1];
    j=len-1;
    for(i=0;i<len;i++)
    {
        res[i] = str[j];
        j--;
    }
    printf("\nReverse of String \"%s\" is: \"%s\" \n", str, res);
    for(i=0;i<len;i++)
    {
        if(res[i] != str[i])
        {
            printf("\nString is not palindrome");
            break;
        }
    }
    if(i == len)
        printf("\nString is palindrome");
}
int main() 
{
    // Write C code here
    char str[50];
    printf("\nEnter a String: ");
    scanf("%s", str);
    printf("\n%s", str);
    palindromeString(str);

    return 0;
}