#include <stdio.h>

int rmo(int, int, int, int, int);
int cmo(int, int, int, int, int);

int main()
{
    int baseAdd, row, col, i, j, w;
    printf("\nEnter Base Address: ");
    scanf("%d",&baseAdd);
    printf("\nEnter total row: ");
    scanf("%d",&row);
    printf("\nEnter total column: ");
    scanf("%d",&col);
    printf("\nEnter at row: ");
    scanf("%d",&i);
    printf("\nEnter at column: ");
    scanf("%d",&j);
    printf("\nEnter weight of word: ");
    scanf("%d",&w);
    int addUsingRMO = rmo(baseAdd, col, i, j, w);
    printf("\nAddress at A[%d][%d] = %d",i, j, addUsingRMO);
    int addUsingCMO = rmo(baseAdd, row, i, j, w);
    printf("\nAddress at A[%d][%d] = %d",i, j, addUsingCMO);
}
int rmo(int baseAdd, int M, int i, int j, int w)
{
    return baseAdd + ((i-1)*M+(j-1))*w;
}
int cmo(int baseAdd, int N, int i, int j, int w)
{
    return baseAdd + ((j-1)*N+(i-1))*w;
}