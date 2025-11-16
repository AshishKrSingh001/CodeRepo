#include <stdio.h>
#include <stdlib.h>
#define size 10

void input(int a[])
{
	printf("Enter %d element of array:\n",size);
	for(int i=0;i<size;i++)
	scanf("%d",&a[i]);
}

void output(int a[])
{
	printf("\nArray:\n");
	for(int i=0;i<size;i++)
	printf("%d\t",a[i]);
	printf("\n");
}

/*
int split(int n[],int min,int max)
{
	int i,j,key,t;
	key = n[min];
	i = min+1;
	j=max;
	while(i>=j)
	{
		while(n[i] < key)
		i++;
		while(n[j] > key)
		j++;
		if(i<j)
		{
			t = n[i];
			n[i] = n[j];
			n[j] = t;
		}
	}
	if(i < j)
	{
		t = n[min];
		n[min] = n[j];
		n[j] = t;
	}
	return j;
}
*/

void swap(int* a, int* b)
{
	int t = *a;
	*a = *b;
	*b = t;
}

int partition(int n[], int min, int max)
{
	int key = n[max];
	int i = (min - 1);

	for (int j = min; j <= max - 1; j++) 
	{
		if (n[j] < key) 
		{
			i++;
			swap(&n[i], &n[j]);
		}
	}
	swap(&n[i + 1], &n[max]);
	return (i + 1);
}

void quicksort(int n[],int min,int max)
{
	int z;
	if(min <= max)
	{
		z = partition(n,min,max);
		//z = split(n,min,max);
		quicksort(n,min,z-1);
		quicksort(n,z+1,max);
	}
}

int main()
{
	int n[] = {1000,900,100,700,600,500,400,300,200,100};
	output(n);
	quicksort(n,0,size-1);
	output(n);
	return 0;
}