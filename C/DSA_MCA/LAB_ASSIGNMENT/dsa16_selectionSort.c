// Write a program in C to implement Selection sort on an given array
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

void swap(int Arr[], int i, int j)
{
    int temp = Arr[i];
    Arr[i] = Arr[j];
    Arr[j] = temp;
}

void selectionSort(int Arr[], int N)
{
    for(int i=0;i<N-1;i++)
    {
        for(int j=i+1;j<N;j++)
        {
            if(Arr[i] > Arr[j])
            swap(Arr, i, j);
        }
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
    selectionSort(Arr, N);
    arrayDisplay(Arr,N,  "After sorting array Elements are: ");
    return 0;
}