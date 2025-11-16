#include <stdio.h>
#define size 20
int A[size],index = -1;
int deleteAtFirst();
int deleteAtEnd();
int deleteElement(int);
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
    printf("\n%d\n",deleteAtFirst());printArray();
    printf("\n%d\n",deleteAtEnd());printArray();
    printf("\n%d\n",deleteAtFirst());printArray();
    printf("\n%d\n",deleteElement(5));printArray();
    printf("\n%d\n",deleteElement(6));printArray();
    printf("\n%d\n",deleteElement(7));printArray();
    printf("\n%d\n",deleteAtEnd());printArray();
    printf("\n%d\n",deleteAtFirst());printArray();
    return 0;
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
int deleteAtFirst()
{
    if(index == -1)
    {
        printf("\nArray is Empty");
        return 0;
    }
    int val = A[0];
    for(int i=1;i<=index;i++)
    {
        A[i-1] = A[i];
    }
    index--;
    printf("\nDeletion At Start");
    return val;
}
int deleteAtEnd()
{
    {
    if(index == -1)
    {
        printf("\nArray is Empty");
        return 0;
    }
    index--;
    printf("\nDeletion At End");
    return A[index+1];
}
}
int deleteElement(int val)
{
    int i;
    for(i=0;i<=index;i++)
    {
        if(A[i]==val)
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
    return val;
}