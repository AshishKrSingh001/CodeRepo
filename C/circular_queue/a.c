#include <stdio.h>
#include <conio.h>
#define size 10

int a[size],front=-1,rear=-1;

void insertq()
{
	if((front==0 && rear==size-1) || rear==front-1)
	{
		printf("\nQueue is full!\n");
		return;
	}
	int val;
	printf("\nEnter data: \n");
	scanf("%d",&val);
	if(front==-1 && rear==-1)
	{
		front++;
		rear++;
		a[rear] = val;
	}
	else if((front==0 && rear!=size-1) || (front>rear && rear!=front-1))
	{
		rear++;
		a[rear] = val;
	}
	else if(rear==size-1 && front>0)
	{
		rear = 0;
		a[rear]=val;
	}
	printf("\nData is Inserted\n");
}

void showq()
{
	if(front==-1 && rear==-1)
	{
		printf("\nQueue is empty!\n");
		return;
	}
	else if(front<=rear)
	{
		printf("\nQueue's Data:\n");
		for(int i=front;i<=rear;i++)
		{
			printf("%d\t",a[i]);
		}
		printf("\n");
	}
	else if(rear<front)
	{
		printf("\nQueue's Data:\n");
		for(int i=front;i<=size-1;i++)
		{
			printf("%d\t",a[i]);
		}
		for(int i=0;i<=rear;i++)
		{
			printf("%d\t",a[i]);
		}
		printf("\n");
	}
}

void deleteq()
{
	if(front==-1 && rear==-1)
	{
		//printf("\nQueue is empty!\n");
		return;
	}
	else if(front==rear)
	{
		front=-1;
		rear=-1;
	}
	else if((front>rear && front<size-1) || front<rear)
	{
		front++;
	}
	else if(front>rear && front==size-1)
	{
		front=0;
	}
	printf("\nData is Deleted\n");
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