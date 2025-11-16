// Write a program in C to implement Radix sort on an given array
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

void countSortWithDigits(int Arr[], int N, int digit)
{
    int max = 9;
    int count[max+1];
    for(int i=0;i<=max;i++)
    count[i] = 0;
    for(int i=0;i<N;i++)
    {
        int ind = (Arr[i]/digit)%10;
        count[ind] += 1;
    }
    for(int i=1;i<=max;i++)
    count[i] += count[i-1];
    int res[N];
    for(int i=N-1;i>=0;i--)
    {
        int ind = (Arr[i]/digit)%10;
        res[--count[ind]] = Arr[i];
    }
    for(int i=0;i<N;i++)
    {
        Arr[i] = res[i];
    }
}

void radixSort(int Arr[], int N)
{
    int max = 0;
    for(int i=0;i<N;i++)
    {
        if(max<Arr[i])
        max = Arr[i];
    }
    for(int digits=1;digits<=max;digits*=10)
    {
        countSortWithDigits(Arr, N, digits);
    }

}

int main()
{
    int N;
    printf("\nEnter Size of Array: \n");
    scanf("%d",&N);
    int Arr[N], key;
    arrayInput(Arr, N);
    arrayDisplay(Arr,N,  "Array Elements are: ");
    radixSort(Arr, N);
    arrayDisplay(Arr,N,  "After sorting array Elements are: ");
    return 0;
}