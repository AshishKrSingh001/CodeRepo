#include <stdio.h>
int fact(int n)
{
    if(n==1)
    return 1;
    else
    return n*fact(n-1);
}
void main()
{
    int num;
    printf("Enter a number:\n");
    scanf("%d",&num);

    printf("Factorial of %d number: %d\n",num,fact(num));
}