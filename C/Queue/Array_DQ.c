#include <stdio.h>
#include <conio.h>
#define size 5

int DQ[size],front=-1,rear=-1;

void DQ_insert_first()
{
	if(front==0)
	{
		puts("\nInsertion not possible at this side!");
		return;
	}
	
	if(rear==-1 && front==-1)
	{
		rear++;
		front++;
	}
	else if(front != 0)
	{
		front--;
	}
	puts("\nEnter data: ");
	scanf("%d",&DQ[front]);
}

void DQ_insert_last()
{
	if(rear==size-1)
	{
		puts("\nInsertion not possible at this side!");
		return;
	}
	
	if(rear==-1 && front==-1)
	{
		rear++;
		front++;
	}
	else
	{
		rear++;
	}
	puts("\nEnter data: ");
	scanf("%d",&DQ[rear]);
}

void DQ_delete_first()
{	
	if(rear==-1 && front==-1)
	{
		puts("\nQueue is empty");
		return;
	}
	if(rear==front)
	{
		front--;
		rear--;
	}
	else
	{
		front++;
	}
}

void DQ_delete_last()
{	
	if(rear==-1 && front==-1)
	{
		puts("\nQueue is empty");
		return;
	}
	if(rear==front)
	{
		front--;
		rear--;
	}
	else
	{
		rear--;
	}
}

void DQ_show()
{
	puts("\nData: ");
	for(int i=front;i<=rear;i++)
	{
		printf("%d\t",DQ[i]);
	}
	puts(" ");
}

int main()
{
	char ch;
	do
	{
		printf("\nEnter your choice\nA:\tInsert First\nB:\tInsert Last\nC:\tDelete First\nD:\tDelete Last\nQ:\tQuit\n->\t");
		ch = getche();
		switch(ch)
		{
			case 'A':
			case 'a':
				DQ_insert_first();
				break;
			case 'B':
			case 'b':
				DQ_insert_last();
				break;
			case 'C':
			case 'c':
				DQ_delete_first();
				break;
			case 'D':
			case 'd':
				DQ_delete_last();
				break;
			case 'Q':
			case 'q':
				break;
			default:
				puts("\nInvalid choice!\n");			
		}
		DQ_show();
	}while(ch != 'q' && ch != 'Q');
}