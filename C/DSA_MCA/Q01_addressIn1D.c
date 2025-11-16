// Write a program in C to implement Merge sort on an given array
#include <stdio.h>

void cycleSort(int A[], int N)
{
    for(int i=0;i<N;i++)
    {
        int pos = i;
        int item = A[i];
        for(int j=i+1;j<N;j++)
        {
            if(A[j]<item)
                pos++;
        }
        if(i == pos)
        continue;
        while(A[pos]==item)
            pos++;
        if(pos != i)
        {
            int temp = A[pos];
            A[pos] = item;
            item = temp;
        }
        while(i!=pos)
        {
            for(int j=i+1;j<N;j++)
            {
                if(A[j]<item)
                    pos++;
            }
            if(i == pos)
            continue;
            while(A[pos]==item)
                pos++;
            if(pos != i)
            {
                int temp = A[pos];
                A[pos] = item;
                item = temp;
            }
        }
    }
}

int main()
{
    int A[] = {4, 5, 12, 84, 2, 36, 11, 105, 74, 47};
    int N = sizeof(A)/sizeof(int);
    for(int i=0;i<N;i++)
    {
        printf("%d\t", A[i]);
    }
    cycleSort(A, N);
    printf("\n");
    for(int i=0;i<N;i++)
    {
        printf("%d\t", A[i]);
    }
    return 0;
}