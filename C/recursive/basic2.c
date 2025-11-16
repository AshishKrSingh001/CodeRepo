#include<stdio.h>

int table(int n,int i){
    
    if(i<=10){
        printf("%d X %d = %d\n",n,i,n*i);
        return table(n,i+1);
    }else{
        return 0;
    }  
}

int main()

{
    int n;
    printf("ENter any number:");
    scanf("%d",&n);
    printf("Sum of digits is %d\n",sum1(n));
    printf("%d\n",table(5,1));
    printf("Factorial = %d\n",factorial(5));
    
    
    return 0;

}