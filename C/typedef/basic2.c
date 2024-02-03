#include<stdio.h>
typedef struct greatest
{
    int gt,a,b,c;
}Greatest;
void main()
{
    Greatest g;
    printf("Enter Three Number's :\n");
    scanf("%d%d%d",&g.a,&g.b,&g.c);
    g.gt=(g.a>g.b && g.a>g.c?g.a:(g.b>g.c?g.b:g.c));
    printf("Greatest Number = %d\n",g.gt);
}