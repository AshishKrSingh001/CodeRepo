#include <stdio.h>

int ackremn(int m, int n)
{
    if(m == 0)
    {
        return n+1;
    }
    else if(m > 0 && n==0)
    {
        return ackremn(m-1, 1);
    }
    else if(m > 0 && n > 0)
    {
        return ackremn(m-1, ackremn(m, n-1));
    }
    return -1; // Optional: return -1 for invalid input
}
int main()
{
    printf("\nGeneral Recommendations\nUse m <= 3 If you want to explore the Ackermann function, keep m at 3 or below\nUse n <= 6 for m = 3\nAvoid m = 4 and higher: Avoid using m values of 4 or greater, especially with non-zero n\n\nFor safe computation:\nValid Inputs: (m,n) pairs such as (0,10), (1,10), (2,5), (3,3)\nAvoid: Any pair with m >= 4 and n > 0.\n");
    int m, n;
    printf("\nEnter two non-negative Integer value for M and N respectively: \n");
    scanf("%d%d", &m, &n);

    if (m < 0 || n < 0) {
        printf("Please enter non-negative integers.\n");
        return 1; // Exit if invalid input
    }

    int ackremnValue = ackremn(m, n);
    printf("\nThe value of Ackremn Function is %d",ackremnValue);
    return 0;
}