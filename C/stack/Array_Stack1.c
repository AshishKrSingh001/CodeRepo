#include <stdio.h>
#include <malloc.h>
#include <conio.h>
#define size 20

int a[size],top=-1;

void push(int data)
{
	if(top>=size)
	{
		printf("\nStack is full!\n");
		return;
	}
	top++;
	a[top]=data;
}

void peep()
{
	if(top==-1)
	{
		printf("\nStack is empty!\n");
	}
	printf("\nData:\n");
	for(int i=top-1;i>=0;i--)
	{
		printf("%d\t",a[i]);
	}
}

void pop()
{
	if(top==-1)
	{
		printf("\nStack is empty!\n");
	}
	top--;
}

int main()
{
	char ch;
	int num;
	do
	{
		printf("\nEnter data:\n");
		scanf("%d",&num);
		push(num);
		printf("\nMore:");
		ch = getche();
	}while(ch != 'n' && ch != 'N');
	peep();pop();
	peep();pop();
	peep();pop();
	peep();pop();
	peep();pop();
	peep();pop();
	peep();pop();
	peep();pop();peep();
	
	
}