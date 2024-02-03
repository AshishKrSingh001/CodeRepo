#include <stdio.h>
int power(int n,int p)
{
    if(p==0)
    return 1;
    else
    return n*power(n,p-1);
}
void main()
{
     int num,p;
    printf("Enter a number and power:\n");
    scanf("%d%d",&num,&p);

    printf("Power of %d  on number %d : %d\n",p,num,power(num,p));
}