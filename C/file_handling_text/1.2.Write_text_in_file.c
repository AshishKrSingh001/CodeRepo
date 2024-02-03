#include <stdio.h>
void main()
{
    FILE *fp;
    char ch;
    fp=fopen("text.txt","w");
    printf("\nEnter information about yourself:\n");

    while((ch=getchar())!=EOF)
    {
        putc(ch,fp);
    }
    fclose(fp);

}