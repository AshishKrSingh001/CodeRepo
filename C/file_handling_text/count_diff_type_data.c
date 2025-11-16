#include <stdio.h>
void main()
{
    FILE *f;
    char ch;

    // f=fopen("Data.dat","w");
    // while((ch=getchar())!=EOF)
    // {
    //     putc(ch,f);
    // }
    // fclose(f);

    f=fopen("Data.dat","r");
    if(f==NULL)
    puts("File not found");
    else
    {
        int l=0,u=0,s=0,d=0,t=0;
        while((ch=getc(f))!=EOF)
        {
            t++;
            if(ch>=48 && ch<=57)
            d++;
            else if(ch>=65 && ch<=90)
            u++;
            else if(ch>=97 && ch<=122)
            l++;
            else
            s++;
        }
        printf("\nTotal character: %d\nDigit: %d\nUppercase character: %d\nLowercase character: %d\nSpecial character: %d",t,d,u,l,s);
        fclose(f);
    }
}