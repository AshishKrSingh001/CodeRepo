#include <stdio.h>

void create(int *a,int n)
{
	printf("\nEnter data: \n");
	for(int i=0;i<n;i++)
	{
		scanf("%d",(a+i));
	}
}
void show(int *a,int n)
{
	printf("\nData: \n");
	for(int i=0;i<n;i++)
	{
		printf("%d\t",*(a+i));
	}
}

int main()
{
	int a[]={10,2,30};
	int n=3;
	show(a,n);
	create(a,n);
	show(a,n);
	return 0;
}