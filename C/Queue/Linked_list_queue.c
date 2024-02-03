#include <stdio.h>
#include <conio.h>
#include <malloc.h>

typedef struct node
{
	int data;
	struct node *next;
}node;

node *front=NULL,*rear=NULL;

void insertq()
{
	node *q;
	q = (node*)malloc(sizeof(node));
	printf("\nEnter data: \n");
	scanf("%d",&q->data);
	q->next = rear;
	if(front==NULL && rear==NULL)
	{
		front = q;
		rear = q;
		return;
	}
	rear = q;
}

void showq()
{
	if(front==NULL && rear==NULL)
	{
		printf("\nQueue is empty\n");
		return;
	}
	
	printf("\nData\n");
	node *p;
	for(p=rear;p!=NULL;p=p->next)
	{
		printf("%d\t",p->data);
	}
}

void deleteq()
{
	if(front==NULL && rear==NULL)
	{
		printf("\nQueue is empty\n");
		return;
	}
	node *p;
	for(p=rear;p->next!=front;p=p->next);
	front = p;
	p=p->next;
	front->next=NULL;
	free(p);
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