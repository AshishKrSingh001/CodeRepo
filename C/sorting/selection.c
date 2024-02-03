#include <stdio.h>
#define size 5

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
	printf("\nSelection sort in Ascending order\n");
}


int main()
{
	int n[] = {1000,900,100,700,600,500,400,300,200,100};
	output(n);
	selection(n);
	output(n);
	return 0;
}