#include <stdio.h>
#include <conio.h>
//#define size 10

//int a[size],front=-1,rear=-1;

void insertq(int *a,int size,int *front,int *rear)
{
	if(*front>=0 && *rear>size)
	{
		printf("\nQueue is full");
		return ;
	}
	else if(*front==-1 && *rear==-1)
	{
		(*front)++;
		(*rear)++;
		printf("\nEnter a number: \n");
		scanf("%d",(a+*rear));
		return;
	}
	else
	{
		(*rear)++;
		printf("\nEnter a number: \n");
		scanf("%d",(a+*rear));
		return;
	}
}

void showq(int *a,int *front,int *rear)
{
	if((*front==-1 && *rear==-1)|| (*front>*rear))
	{
		printf("\nQueue is empty\n");
		return;
	}
	printf("\nData\n");
	for(int i=*rear;i>=*front;i--)
	{
		printf("%d\t",*(a+i));
	}
}

void deleteq(int *a,int *front,int *rear)
{
	if(*front==-1 && *rear==-1)
	{
		printf("\nQueue is empty\n");
		return;
	}
	else
	{
		printf("\nData is deleted\n");
		(*front)++;
		return;
	}
}

int main()
{
	char ch;
	int n;
	printf("\nEnter maximum size of Queue: \n");
	scanf("%d",&n);
	int Q[n],front=-1,rear=-1;
	do
	{
		printf("\nEnter choice: \nI: Insert\nD: delete\n->");
		ch = getche();
		
		switch(ch)
		{
			case 'I':
			case 'i':
			insertq(Q,n,&front,&rear);
			break;
			case 'D':
			case 'd':
			deleteq(Q,&front,&rear);
			break;
			case 'Q':
			case 'q':
			break;
			default:
			printf("Invalid command");
		}
		showq(Q,&front,&rear);
	}while(ch == 'i' || ch == 'I' || ch == 'd' || ch == 'D');
	
	return 0;
}