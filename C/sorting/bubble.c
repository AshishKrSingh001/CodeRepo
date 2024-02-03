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

void bubble(int a[])
{
	for(int i=0;i<size-1;i++)
	{
		for(int j=0;j<size-i-1;j++)
		{
			if(a[j]>a[j+1])
			{
				int temp = a[j];
				a[j] = a[j+1];
				a[j+1] = temp;
			}
		}
	}
	printf("\nBubble sort in Ascending order\n");
}


int main()
{
	int n[] = {1000,900,100,700,600,500,400,300,200,100};
	output(n);
	bubble(n);
	output(n);
	return 0;
}