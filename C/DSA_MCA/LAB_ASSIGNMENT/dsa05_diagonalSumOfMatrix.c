// Write a program in C to find diagonal sum of given Matrix
#include <stdio.h>
#define N 5

void matrixInput(int Arr[][N])
{
    printf("\nEnter %d element for 2-D Array\n", N*N);
    for(int i=0;i<N;i++)
    {
        for(int j=0;j<N;j++)
        {
            scanf("%d", &Arr[i][j]);
        }
    }
}
void matrixDisplay(int Arr[][N], char msg[])
{
    printf("\n%s\n",msg);
    for(int i=0;i<N;i++)
    {
        for(int j=0;j<N;j++)
        {
            printf("%d", Arr[i][j]);
            if(j!=N-1)
            {
                printf(", ");
            }
        }
        printf("\n");
    }
}
void matrixDiagonalAddition(int Arr[][N])
{
    int add = 0;
    for(int i=0;i<N;i++)
    {
        add += Arr[i][i];
    }
    printf("Addition of Diaginal Of Matrix is %d", add);
}

int main()
{
    int Arr[N][N];
    matrixInput(Arr);
    matrixDisplay(Arr, "Matrix Elements are: ");
    matrixDiagonalAddition(Arr);
    return 0;
}