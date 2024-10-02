#include <stdio.h>
#define size 20
int A[size],index = -1;
int deleteKthElement(int);
void printArray();
int main()
{
    printf("\nEnter 5 element\n");
    for(int i=0;i<5;i++)
    {
        scanf("%d",&A[i]);
        index++;
    }
    printArray();
    printf("\n%d\n",deleteKthElement(0));printArray();
    return 0;
}
int deleteKthElement(int pos)
{
    int i;
    for(i=0;i<=index;i++)
    {
        if(i==pos)
        {
            break;
        }
    }
    if(i==index+1)
    {
        return 0;
        printf("\nValue not found");
    }
    for(int j=i;j<index;j++)
    {
        A[j] = A[j+1];
    }
    index--;
    printf("\nDeletion At Position %d", i);
    return A[pos];
}
void printArray()
{
    printf("\nArray element is: \n");
    for(int i=0;i<=index;i++)
    {
        printf("%d",A[i]);
        if(i!=index)
            printf("\t");
    }
}