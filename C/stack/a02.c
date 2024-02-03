//  Linked_list_stack.c
#include <stdio.h>
#include <conio.h>
#include <malloc.h>

typedef struct node
{
	int data;
	struct node *next;
}node;

//node *top = NULL;

node  *push(node *top)
{
	node *q;
	q = (node*)malloc(sizeof(node));
	printf("\n\nEnter Data: \n");
	scanf("%d",&q->data);
	q->next = top;
	printf("\nData is Inserted\n");
	return q;
}

void peep(node *top)
{
	if(top == NULL)
	{
		printf("\nStack is empty!\n");
		return;
	}
	node *p;
	int i;
	printf("\nPosition:\tData:\tAddress\tNext\n");
	for(i=1,p=top;p != NULL;i++,p=p->next)
	{
		printf("%d\t\t%d\t%d\t%d\n",i,p->data,p,p->next);
	}
}

node *pop(node *top)
{
	if(top == NULL)
	{
		//printf("\nStack is empty!\n");
		return top;
	}
	node *t;
	t = top;
	top = top->next;
	free(t);
	printf("\n\nData is Deleted\n");
	return top;
}

void choice()
{
	char ch;
	node *top=NULL;
	do
	{
		printf("\nEnter\nI: Push\nD: Pop\nQ: Quit\n->");
		ch = getche();
		switch(ch)
		{
			case 'I':
			case 'i':
			top = push(top);
			break;
			
			case 'D':
			case 'd':
			top = pop(top);
			break;
			
			case 'q':
			case 'Q':
			break;
			
			default:
			printf("\nInvalid choice!");
		}
		peep(top);
	}while(ch == 'I' || ch == 'i' || ch == 'D' || ch == 'd');
}

int main()
{
	choice();
	return 0;
}