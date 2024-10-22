// Write a program in C to implement Merge sort on an given array
#include <stdio.h>
#include <limits.h>

void arrayInput(int Arr[], int N)
{
    printf("\nEnter %d element for 1-D Array\n", N);
    for(int i=0;i<N;i++)
    {
        scanf("%d", &Arr[i]);
    }
}
void arrayDisplay(int Arr[], int N, char msg[])
{
    printf("\n%s\n",msg);
    for(int i=0;i<N;i++)
    {
        printf("%d", Arr[i]);
        if(i!=N-1)
        {
            printf(", ");
        }
    }
}

void swap(int Arr[], int i, int j)
{
    int temp = Arr[i];
    Arr[i] = Arr[j];
    Arr[j] = temp;
}

void mergeSort(int A[], int N, int B[], int M, int res[])
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

int main()
{
    int N, M;
    printf("\nEnter Size of Array1: \n");
    scanf("%d",&N);
    int A[N];
    arrayInput(A, N);
    arrayDisplay(A,N,  "Array1 Elements are: ");

    printf("\nEnter Size of Array1: \n");
    scanf("%d",&M);
    int B[N];
    arrayInput(B, N);
    arrayDisplay(B,N,  "Array1 Elements are: ");

    int res[N+M];
    mergeSort(A, N, B, M, res);
    arrayDisplay(res,N+M,  "After sorting array Elements are: ");
    return 0;
}