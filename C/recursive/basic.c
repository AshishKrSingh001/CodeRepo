/*
    Recursive function:
        1. A function call itself called recursive function and this process is called recursive.
        2. Recursive function is used to solve complex problem program.
        3. This function doesn't contain looping function.
        4. It's coding is verry less rather than iterative function.

        Rules for making Recursive function:
            1. Function must be argumented/parameterized.
            2. It should be returntype.
            3. We call recursive function with parameter during modification time.
            4. We specify base condition for stop.
*/
// WAP to input a number after that add all number smaller than than.
#include <stdio.h>
int addition(int n)
{
    if(n==1)
    return 1;
    else
    return n+addition(n-1);
}
void main()
{
    int num;
    printf("Enter a number:\n");
    scanf("%d",&num);

    printf("Addition of %d number: %d\n",num,addition(num));
}