#include <stdio.h>
#include <string.h>
void palindromeString(char str[])
{
    int i, j;
    int len = strlen(str);
    printf("\nLength of String \"%s\" is: %d",str,len);
    
    char res[len];
    strcpy(res, strrev(str));
    printf("\nReverse of String \"%s\" is: \"%s\"",str,res);
    if(strcmp(res, str) == 0)
    {
        printf("\nString \"%s\" is palindrome");
    }
    else
    {
        printf("\nString \"%s\" is not palindrome");
    }
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