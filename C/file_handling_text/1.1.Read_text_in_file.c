#include <stdio.h>
void main()
{
    FILE *fp;
    char ch;
    fp=fopen("text.txt","r");
    if(fp==NULL)
    printf("File not found");
    else
    {
        while((ch=getc(fp))!=EOF)
        putch(ch);
        // printf("%c",ch);
    }
    fp=fclose(fp);

}