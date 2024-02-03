#include <stdio.h>
#include <malloc.h>

void input(int *a,int n)
{
	printf("Enter %d element of array:\n",n);
	for(int i=n-1;i>=0;i--)
	{
		scanf("%d",&a[i]);
	}
}

void output(int *a,int n)
{
	printf("Data\tAddress:\n");
	for(int i=0;i<n;i++)
	{
		printf("%d\t%d\n",a[i],&a[i]);
	}
}

int main()
{
	int n;
	printf("\nEnter size of array:\n");
	scanf("%d",&n);
	int a[n];
	input(a,n);
	output(a,n);
}