#include <stdio.h>
#include <malloc.h>
#include <conio.h>

void push(int *a,int n,int *top)
{
	if(*top>=n)
	{
		printf("\nStack is full!\n");
		return;
	}
	(*top)++;
	//*(a+*top)=data;
	printf("\nEnter data:\n");
	scanf("%d",(a+*top));
}

void peep(int *a,int *top)
{
	if(*top==-1)
	{
		printf("\nStack is empty!\n");
		return;
	}
	printf("\nData:\n");
	for(int i=*top;i>=0;i--)
	{
		printf("%d\t",*(a+i));
	}
}

void pop(int *a,int *top)
{
	if(*top==-1)
	{
		printf("\nStack is empty!\n");
		return;
	}
	(*top)--;
}

int main()
{
	char ch;
	int n;
	printf("\nEnter maximum size of Queue: \n");
	scanf("%d",&n);
	int Q[n],top=-1;
	do
	{
		printf("\nEnter choice: \nI: Insert\nD: delete\n->");
		ch = getche();
		
		switch(ch)
		{
			case 'I':
			case 'i':
			push(Q,n,&top);
			break;
			case 'D':
			case 'd':
			pop(Q,&top);
			break;
			case 'Q':
			case 'q':
			break;
			default:
			printf("Invalid command");
		}
		peep(Q,&top);
	}while(ch == 'i' || ch == 'I' || ch == 'd' || ch == 'D');
	
	return 0;
}