#include <stdio.h>
#define row 3
#define col 3

int main()
{
    int A[row][col];
    printf("\nEnter %d element in 2D array: \n",row*col);
    for(int i=0;i<row;i++)
    {
        for(int j=0;j<col;j++)
        {
            scanf("%d",&A[i][j]);
        }
    }
    int aboveSum = 0;
    int belowSum = 0;
    for(int i=0;i<row;i++)
    {
        for(int j=col-1;j>=i;j--)
        {
            if(i==j)continue;
            aboveSum += A[i][j];
        }
        for(int j=0;j<=i;j++)
        {
            if(i==j)continue;
            belowSum += A[i][j];
        }
    }
    printf("Above Matrix: %d\nBelow Matrix: %d",aboveSum,belowSum);
}