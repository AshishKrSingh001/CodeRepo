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

void insertion(int n[])
{
	int i,j,k,t;
	for(i=0;i<=size-2;i++)
	{
		for(j=i+1;j<=size-1;j++)
		{
			if(n[i] > n[size-1])
			{
				t = n[j];
				for(k=j;k>i;k--)
				{
					n[k] = n[k-1];
				}
				n[k] = t;
			}
		}
	}
}

int main()
{
	int n[] = {1000,900,100,700,600,500,400,300,200,100};
	output(n);
	insertion(n);
	output(n);
	return 0;
}
