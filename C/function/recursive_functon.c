#include <stdio.h>
int recur(int n)
{
    if(n==1)
    return 1;
    else
    return (n)+recur(n-1);
    
}
void main()
{
    int a=5;
    printf("%d",recur(a));
}