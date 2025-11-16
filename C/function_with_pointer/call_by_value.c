#include <stdio.h>
//A userdefined function used to swap
void swapping(int a,int b)
{
    a=a-b;
    b=a+b;
    a=b-a;

    printf("After swapping\na=%d\nb=%d\n",a,b);
}
void main()
{
    int p,q;
    printf("Enter two numbers:\n");
    scanf("%d%d",&p,&q);
    printf("Before calling\np=%d\nq=%d\n",p,q);
    swapping(p,q);
    printf("After calling\np=%d\nq=%d",p,q);

}