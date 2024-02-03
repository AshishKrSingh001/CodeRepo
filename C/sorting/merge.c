#include <stdio.h>
#define s1 5
#define s2 5

void input(int a[],int size)
{
	printf("Enter %d element of array:\n",size);
	for(int i=0;i<size;i++)
	scanf("%d",&a[i]);
}

void output(int a[],int size)
{
	printf("\nArray:\n");
	for(int i=0;i<size;i++)
	printf("%d\t",a[i]);
	printf("\n");
}

void mergeSort(int a[],int b[],int c[])
{
    int i=0,j=0,k=0;
    while(i<s1 && j<s2)
    {
		printf("a");
        while(a[i]<=b[j])
        {
            c[k]=a[i];
            k++;
            i++;
        }
        while(a[i]>b[j])
        {
            c[k]=b[j];
            k++;
            j++;
        }
    }
    if(i>s1-1)
    {
        while(j<s2)
        {
            c[k]=b[j];
            k++;
            j++;
        }
    }
    else
    {
        while(i<s1)
        {
            c[k]=a[i];
            k++;
            i++;
        }
    }
}



int main()
{
	int a[] = {1,2,3,4,5};
	output(a,s1);
	int b[] = {1,5,9,13,17};
	output(b,s2);
	int c[s1+s2];
	mergeSort(a,b,c);
	output(c,(s1+s2));
	return 0;
}

