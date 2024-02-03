#include <stdio.h>
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
}

int bin_search(int n[],int val)
{
	int min = 0;
	int max = size-1;
	int mid;
	while(min<=max)
	{
		mid = (min+max)/2;
		if(n[mid] > val)
			max = mid-1;
		else if(n[mid] < val)
			min = mid+1;
		else if(n[mid] == val)
		{
			return 1;
		}
	}
	return 0;
}

void selection(int a[])
{
	for(int i=0;i<size-1;i++)
	{
		for(int j=i+1;j<size;j++)
		{
			if(a[i]>a[j])
			{
				int temp = a[i];
				a[i] = a[j];
				a[j] = temp;
			}
		}
	}
	printf("\n\nSelection sort in Ascending order\n");
}

int main()
{
	int n[size];
	input(n);
	output(n);
	selection(n);
	output(n);
	printf("\nEnter the value you want to search:\n");
	int val;
	scanf("%d",&val);
	if(bin_search(n,val)==1)
		puts("\nFound");
	else
		puts("\nNot Found");
	return 0;
}