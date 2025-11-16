// Write a program in C to implement Binary Search on an given array
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
void binarySearch(int Arr[], int N, int key)
{
    int start = 0;
    int end = N-1;
    while(start<=end)
    {
        int mid = (start+end)/2;
        if(Arr[mid] == key)
        {
            printf("\nELement found at \'%d\' Index", mid);
            return;
        }
        else if(Arr[mid] > key)
        {
            end = mid - 1;
        }
        else
        {
            start = mid + 1;
        }
    }
    printf("\nELement Not found");

}
int main()
{
    int N;
    printf("\nEnter Size of Array: \n");
    scanf("%d",&N);
    int Arr[N], key;
    arrayInput(Arr, N);
    arrayDisplay(Arr,N,  "Array Elements are: ");
    printf("\nEnter key Element to be searched in Array: \n");
    scanf("%d",&key);
    binarySearch(Arr, N, key);
    
    return 0;
}