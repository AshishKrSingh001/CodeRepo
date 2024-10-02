#include <stdio.h>
#include <limits.h>

void printArray(int[],int);
void mergeSortedArray(int A[], int N, int B[], int M, int res[]);

int main()
{
    int A[] = {7, 9, 10, 20};
    int nA = sizeof(A)/sizeof(int);
    printArray(A, nA);

    int B[] = {1, 5, 8, 15};
    int nB = sizeof(B)/sizeof(int);
    printArray(B, nB);

    int res[nA+nB];
    mergeSortedArray(A, nA, B, nB, res);
    printArray(res, nA+nB);
    return 0;
}
void mergeSortedArray(int A[], int N, int B[], int M, int res[])
{
    int i=0, j=0, k=0;
    while(i<N || j<M)
    {
        int val1 = (i<N)?A[i]:INT_MAX;
        int val2 = (j<M)?B[j]:INT_MAX;
        if(val1<=val2)
        {
            res[k] = val1;
            i++;
            k++;
        }
        else
        {
            res[k] = val2;
            j++;
            k++;
        }

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