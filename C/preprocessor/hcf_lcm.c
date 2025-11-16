#include <stdio.h>
#define gt(a,b,c) (a>b && a>c)?a:(b>c)?b:c
#define sm(a,b,c) (a<b && a<c)?a:(b<c)?b:c

int a,b,c;

void input()
{
    printf("Enter three number:\n");
    scanf("%d%d%d",&a,&b,&c);
}
int LCM(int a,int b,int c)
{
    int g=gt(a,b,c);
    while(g%a!=0 || g%b!=0 || g%c!=0)
    g++;
    return g;

}
int HCF(int a,int b,int c)
{
    int g=sm(a,b,c);
    while(a%g!=0 || b%g!=0 || c%g!=0)
    g--;
    return g;

}
void display()
{
    input();
    printf("Greatest number: %d\n",gt(a,b,c));
    printf("HCF: %d\n",HCF(a,b,c));
    printf("LCF: %d\n",LCM(a,b,c));
}
void main()
{
    display();
}

