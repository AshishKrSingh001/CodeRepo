// Write a program in C to implement Linear Search on an given array
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
void linearSearch(int Arr[], int N, int key)
{
    for(int i=0;i<N;i++)
    {
        if(Arr[i] == key)
        {
            printf("\nELement found at \'%d\' Index", i);
            return;
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
    linearSearch(Arr, N, key);
    
    return 0;
}