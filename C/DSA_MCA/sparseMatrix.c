// Online C compiler to run C program online
#include <stdio.h>
#define M 4
#define N 4
typedef struct B
{
    int row;
    int col;
    int val;
};
void input(int sparse[][N])
{
    printf("\nEnter %d element of array\n", M*N);
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            scanf("%d", &sparse[i][j]);
        }
    }
}
void output(int sparse[][N])
{
    printf("\n********************SPARSE_MATRIX_START********************\n");
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            printf("%d", sparse[i][j]);
            if(j != N-1)
            {
                printf(", ");
            }
        }
        printf("\n");
    }
    printf("********************SPARSE_MATRIX_END********************\n");
}
int countNonZeroElement(int sparse[][N])
{
    int count = 0;
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            if(sparse[i][j] != 0)
            count++;
        }
    }
    return count;
}
void calculateBMatrix(int sparse[][N], struct B b[])
{
    int ind = -1;
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            if(sparse[i][j] != 0)
            {
                b[++ind].row = i;
                b[ind].col = j;
                b[ind].val = sparse[i][j];
            }
        }
    }
}
void printBMatrix(struct B b[], int size)
{
    printf("\n********************B_MATRIX_START********************\n");
    printf("B Matrix is: \nROW\tCOLUMN\tVALUE\n");
    for(int i=0;i<size;i++)
    {
        printf("%d\t%d\t%d\n", b[i].row, b[i].col, b[i].val);
    }
    printf("********************B_MATRIX_END********************\n");
}
int main() 
{
    int sparse[M][N];
    input(sparse);
    output(sparse);
    int noOfNonZeroElement = countNonZeroElement(sparse);
    struct B b[noOfNonZeroElement];
    calculateBMatrix(sparse, b);
    printBMatrix(b, noOfNonZeroElement);
    return 0;
}