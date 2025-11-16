#include <stdio.h>
#include <conio.h>
#define size 10

int a[size],front=-1,rear=-1;

void insertq()
{
	if(front>=0 && rear>size)
	{
		printf("\nQueue is full");
		return ;
	}
	else if(front==-1 && rear==-1)
	{
		front++;
		rear++;
		printf("\nEnter a number: \n");
		scanf("%d",&a[rear]);
		return;
	}
	else
	{
		rear++;
		printf("\nEnter a number: \n");
		scanf("%d",&a[rear]);
		return;
	}
}

void showq()
{
	if(front==-1 && rear==-1)
	{
		printf("\nQueue is empty\n");
		return;
	}
	if(front>rear)
	{
		printf("\nQueue is empty\n");
		return;
	}
	printf("\nData\n");
	for(int i=rear;i>=front;i--)
	{
		printf("%d\t",a[i]);
	}
}

void deleteq()
{
	if(front==-1 && rear==-1)
	{
		printf("\nQueue is empty\n");
		return;
	}
	else
	{
		printf("\nData is deleted\n");
		front++;
		return;
	}
}

int main()
{
	char ch;
	
	do
	{
		printf("\nEnter choice: \nI: Insert\nD: delete\n->");
		ch = getche();
		
		switch(ch)
		{
			case 'I':
			case 'i':
			insertq();
			break;
			case 'D':
			case 'd':
			deleteq();
			break;
			case 'Q':
			case 'q':
			break;
			default:
			printf("Invalid command");
		}
		showq();
	}while(ch == 'i' || ch == 'I' || ch == 'd' || ch == 'D');
	
	return 0;
}