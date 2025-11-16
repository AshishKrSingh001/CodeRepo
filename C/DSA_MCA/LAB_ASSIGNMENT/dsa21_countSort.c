// Write a program in C to implement Count sort on an given array
#include <stdio.h>

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

void countSort(int Arr[], int N, int res[])
{
    int max = 0;
    for(int i=0;i<N;i++)
    {
        if(max < Arr[i])
        max = Arr[i];
    }
    int count[max+1];
    for(int i=0;i<=max;i++)
    count[i] = 0;
    for(int i=0;i<N;i++)
    {
        int ind = Arr[i];
        count[ind] += 1;
    }
    for(int i=1;i<=max;i++)
    count[i] += count[i-1];

    for(int i=N-1;i>=0;i--)
    {
        res[--count[Arr[i]]] = Arr[i];
    }
}

int main()
{
    int N;
    printf("\nEnter Size of Array: \n");
    scanf("%d",&N);
    int Arr[N], key, res[N];
    arrayInput(Arr, N);
    arrayDisplay(Arr,N,  "Array Elements are: ");
    countSort(Arr, N, res);
    arrayDisplay(res,N,  "After sorting array Elements are: ");
    return 0;
}