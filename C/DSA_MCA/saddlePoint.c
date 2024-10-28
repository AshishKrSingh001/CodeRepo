#include <stdio.h>
#define M 3
#define N 3
void input(int matrix[][N])
{
    printf("\nEnter %d element of array\n", M*N);
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            scanf("%d", &matrix[i][j]);
        }
    }
}
void output(int matrix[][N])
{
    printf("\n********************SPARSE_MATRIX_START********************\n");
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            printf("%d", matrix[i][j]);
            if(j != N-1)
            {
                printf(", ");
            }
        }
        printf("\n");
    }
    printf("********************SPARSE_MATRIX_END********************\n");
}
void findSaddlePoint(int matrix[][N])
{
    for(int i=0;i<M;i++)
    {
        int minofRow = matrix[i][0];
        int col = 0;
        for(int j=0;j<N;j++)
        {
            if(minofRow > matrix[i][j])
            {
                minofRow = matrix[i][j];
                col = j;
            }
        }
        int k;
        for(k=0;k<M;k++)
        {
            if(minofRow < matrix[k][col])
            {
                break;
            }
        }
        if(k==M)
        {
            printf("\nSaddle Point found at \nrow index is %d\ncolumn index is %d\nvalue is %d", i, col, minofRow);
            return;
        }
    }
    printf("\nSaddle point not found");
}
int main() 
{
    int matrix[M][N];
    input(matrix);
    output(matrix);
    findSaddlePoint(matrix);
}