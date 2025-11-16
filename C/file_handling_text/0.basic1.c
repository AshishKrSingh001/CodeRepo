/*
    1. getc():This function is used to read one character from a file.
        syntax:
            char getc(file pointer);

        example:
            char ch;
            ch=getc(fp);

    2. putc():This fuction is used to write one character in a file.
        syntax:
            void putc(char.value,file pointer);

        example: 

        These function is unformated input operation(Doesn't use format specifier)
        getch():Not visible in console and doesn't require to press enter key
        getche():Visble in console and doesn't require to press enter key
        getchar():Visble in console and require to press enter key
*/
#include <stdio.h>

void main()
{
    FILE *fp;
    char ch;
    fp=fopen("my_info.txt","r");

    if(fp==NULL)
    printf("File not found");
    else
    {
        while((ch=getc(fp))!='\0')
        printf("%c",ch);
    }
    fclose(fp);
}