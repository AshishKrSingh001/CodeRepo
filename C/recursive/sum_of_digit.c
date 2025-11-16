#include <stdio.h>

int sum1(int n){
    static int sum=0;
    if(n>0){
        int d=n%10;
        sum +=d;
        n=sum1(n/10);
    }
    return(sum);
}

void main()
{
    int num;
    printf("Enter any number:\n");
    scanf("%d",&num);

    printf("Sum of digit: %d\n",sum1(num));
}