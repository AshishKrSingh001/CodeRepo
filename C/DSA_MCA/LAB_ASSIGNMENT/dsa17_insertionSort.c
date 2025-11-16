// Write a program in C to implement Insertion sort on an given array
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

void insertionSort(int Arr[], int N)
{
    for(int i=1;i<N;i++)
    {
        int key = Arr[i];
        int j = i-1;
        while(j>0 && key < Arr[j])
        {
            Arr[j+1] = Arr[j];
            j--;
        }
        Arr[j+1] = key;
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
    insertionSort(Arr, N);
    arrayDisplay(Arr,N,  "After sorting array Elements are: ");
    return 0;
}