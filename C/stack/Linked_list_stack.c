//  Linked_list_stack.c
#include <stdio.h>
#include <conio.h>
#include <malloc.h>

typedef struct node
{
	int data;
	struct node *next;
}node;

node *top = NULL;

void push()
{
	node *q;
	q = (node*)malloc(sizeof(node));
	if(q==NULL)
	{
		printf("\nMemory is full \n");
		return ;
	}
	printf("\n\nEnter Data: \n");
	scanf("%d",&q->data);
	q->next = top;
	top = q;
	printf("\nData is Inserted\n");
}

void peep()
{
	if(top == NULL)
	{
		printf("\nStack is empty!\n");
		return;
	}
	node *p;
	int i;
	printf("\nPosition:\tData:\tAddress\t\tNext\n");
	for(i=1,p=top;p != NULL;i++,p=p->next)
	{
		printf("%d\t\t%d\t%d\t%d\n",i,p->data,p,p->next);
	}
}

void pop()
{
	if(top == NULL)
	{
		printf("\nStack is empty!\n");
		return;
	}
	node *t;
	t = top;
	top = top->next;
	free(t);
	printf("\n\nData is Deleted\n");
}

int main()
{
	char ch;
	do
	{
		printf("\nEnter\nI: Push\nD: Pop\nQ: Quit\n->");
		ch = getche();
		switch(ch)
		{
			case 'I':
			case 'i':
			push();
			break;
			
			case 'D':
			case 'd':
			pop();
			break;
			
			case 'q':
			case 'Q':
			break;
			
			default:
			printf("\nInvalid choice!");
		}
		peep();
	}while(ch == 'I' || ch == 'i' || ch == 'D' || ch == 'd');
	return 0;
}