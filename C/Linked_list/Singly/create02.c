#include <stdio.h>
#include <malloc.h>
#include <conio.h>

typedef struct node
{
	char name[20];
	struct node *next;
}node;

node *create()
{
	node *h,*p,*q;
	h = (node*)malloc(sizeof(node));
	printf("Enter name:\n");
	gets(h->name);
	h->next=NULL;
	p=h;
	
	char ch;
	printf("\nDo you want to enter more(y/n):\n");
	ch = getche();
	
	while(ch!='n' && ch!='N')
	{
		q = (node*)malloc(sizeof(node));
		printf("\n\nEnter name:\n");
		gets(q->name);
		q->next=NULL;
		p->next=q;
		p=q;
		
		printf("\nDo you want to enter more(y/n):\n");
		ch = getche();
	}
	return h;
}

void traverse(node *h)
{
	printf("\n\nYour data is:");
	while(h!=NULL)
	{
		printf("\n%s",h->name);
		h=h->next;
	}
}

int main()
{
	node *head;
	head=create();
	traverse(head);
	return 0;
}