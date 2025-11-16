#include <stdio.h>
#define size 20
int A[size],index = -1;
void insertionAtFirst(int);
void insertionAtEnd(int);
void insertionAtPosition(int,int);
void printArray();
// for sorted Array
int findIndexForInsertion(int val);
void insertionInSortedArray(int val);
int main()
{
    // insertionAtEnd(10);
    // printArray();
    // insertionAtPosition(20,0);
    // printArray();
    // insertionAtFirst(100);
    // printArray();
    insertionInSortedArray(10); printArray();
    insertionInSortedArray(30); printArray();
    insertionInSortedArray(50); printArray();
    insertionInSortedArray(20); printArray();
    insertionInSortedArray(10); printArray();
    insertionInSortedArray(20); printArray();
    insertionInSortedArray(55); printArray();
    insertionInSortedArray(34); printArray();
    insertionInSortedArray(74); printArray();
    insertionInSortedArray(2); printArray();
    insertionInSortedArray(110); printArray();
    insertionInSortedArray(5); printArray();
    insertionInSortedArray(34); printArray();
    insertionInSortedArray(74); printArray();
    insertionInSortedArray(2); printArray();
    insertionInSortedArray(110); printArray();
    insertionInSortedArray(5); printArray();
   
    return 0;
}
void insertionAtFirst(int val)
{
    if(index == size-1)
    {
        printf("\nArray is full");
        return;
    }
    if(index==-1)
    {
        A[++index] = val;
        printf("\nInsertion At Start");
        return;
    }
    for(int i=index+1;i>0;i--)
    {
        A[i] = A[i-1];
    }
    A[0] = val; 
    index++;
    printf("\nInsertion At Start");
}
void insertionAtEnd(int val)
{
    if(index == size-1)
    {
        printf("\nArray is full");
        return;
    }
    A[++index] = val;
     printf("\nInsertion At End");
}
void insertionAtPosition(int val, int position)
{
    if(position<0 && position>index+1)
    {
        printf("\nInvalid position");
        return;
    }
    if(index == size-1)
    {
        printf("\nArray is full");
        return;
    }
    for(int i=index+1;i>position;i--)
    {
        A[i] = A[i-1];
    }
    A[position] = val;
    index++;
    printf("\nInsertion At given Position %d",position);
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

// for sorted Array
int findIndexForInsertion(int val)
{
    if(val<=A[0])
    {
        return 0;
    }
    if(val>=A[index])
    {
        return index+1;
    }
    int start = 0, end = index, ceil=0;
    while(start<=end)
    {
        int mid = (start+end)/2;
        if(A[mid]<=val)
        {
            start = mid + 1;
        }
        else if(A[mid]>val)
        {
            end = mid - 1;
            ceil = mid;
        }
    }
    return ceil;
}
void insertionInSortedArray(int val)
{
    int ind = findIndexForInsertion(val);
    insertionAtPosition(val, ind);
}