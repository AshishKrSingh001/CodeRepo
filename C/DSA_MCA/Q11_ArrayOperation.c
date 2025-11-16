#include <Stdio.h>

void printArray(int Arr[], int N);
void reverseOfArray(int A[], int N, int B[]);
void arrayAddition(int A[], int N, int B[], int C[]);
int main()
{
    int A[] = {10, 20, 30, 40, 50};
    int N = sizeof(A)/sizeof(int);
    printArray(A, N);
    int B[N];
    reverseOfArray(A, N, B);
    printArray(B, N);
    int C[N];
    arrayAddition(A, N, B, C);
    printArray(C, N);
    return 0;
}
void reverseOfArray(int A[], int N, int B[])
{
    for(int i=N-1,j=0;i>=0;i--,j++)
    {
        B[j] = A[i];
    }
}
void arrayAddition(int A[], int N, int B[], int C[])
{
    for(int j=0;j<N;j++)
    {
        C[j] = B[j] + A[j];
    }
}
void printArray(int Arr[], int N)
{
    printf("\nArray element is: \n");
    for(int i=0;i<N;i++)
    {
        printf("%d",Arr[i]);
        if(i!=N-1)
            printf("\t");
    }
}