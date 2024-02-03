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

int lin_search(int n[],int val)
{
	for(int i=0;i<size;i++)
	{
		if(n[i] == val)
		{
			return 1;
		}
	}	
	return 0;
}

int main()
{
	int n[size];
	input(n);
	output(n);
	printf("\nEnter the value you want to search:\n");
	int val;
	scanf("%d",&val);
	if(lin_search(n,val)==1)
		puts("\nFound");
	else
		puts("\nNot Found");
	return 0;
}