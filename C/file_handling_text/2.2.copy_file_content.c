#include <stdio.h>
void main()
{
    FILE *file1,*file2;
    char ch;
    
    file1=fopen("abc.txt","r");
    file2=fopen("abc2.txt","w");
    if(file1==NULL)
    puts("File not found");
    else
    {
        while((ch=getc(file1))!=EOF)
        {
           putc(ch,file2);
        }
        puts("File copied");
    }
    fclose(file1);
    fclose(file2);
    

}