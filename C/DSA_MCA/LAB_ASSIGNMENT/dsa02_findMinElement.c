// Write a program in C to find min element in given array
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
void minElement(int Arr[], int N)
{
    int min = Arr[0], ind=0;
    for(int i=1;i<N;i++)
    {
        if(Arr[i] < min)
        {
            min = Arr[i];
            ind = i;
        }
    }
    printf("\nMin ELement is \'%d\' at \'%d\' Index", min, ind);

}
int main()
{
    int N;
    printf("\nEnter Size of Array: \n");
    scanf("%d",&N);
    int Arr[N];
    arrayInput(Arr, N);
    arrayDisplay(Arr,N,  "Array Elements are: ");
    minElement(Arr, N);
    
    return 0;
}