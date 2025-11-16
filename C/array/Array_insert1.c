#include <stdio.h>
#define size 10

int a[size];
int n=size/2;
void input()
{
	printf("\nEnter value %d value\n",n);
	for(int i=0;i<n;i++)
		scanf("%d",&a[i]);
}
void output()
{
	printf("\nArray\n");
	for(int i=0;i<n;i++)
		printf("%d\t",a[i]);
	printf("\n");
}

void insert(int val,int index)
{
	if(index>n && index<0)
	{
		printf("\nInvalid index");
		return;
	}
	if(index==n)
	{
		a[n]=val;
		n++;
		return;
	}
	for(int i=n;i>index;i--)
		a[i]=a[i-1];
	a[index]=val;
	n++;
}

void delete1(int index)
{
	if(index>=n && index<0)
	{
		printf("\nInvalid index");
		return;
	}
	for(int i=index;i<n-1;i++)
		a[i]=a[i+1];
	n--;
}

int main()
{
	size=size-1;
	printf("%d",size);
	
	input();
	output();
	insert(100,3);
	output();
	delete1(4);
	output();
	return 0;
}