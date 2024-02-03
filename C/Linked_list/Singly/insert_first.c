
#include <stdio.h>
#include <conio.h>
#include <malloc.h>

typedef struct node
{
	int data;
	struct node *next;
}node;

node *create()
{
	node *head,*p,*q;
	char ch;
	head = (node*)malloc(sizeof(node));
	printf("\nEnter data:\n");
	scanf("%d",&head->data);
	head->next=NULL;
	p=head;
	printf("\nMore(Y/N):\n");
	//scanf("%c",&ch);
	ch = getche();
	
	while(ch!='n' && ch!='N')
	{
		q = (node *)malloc(sizeof(node));
		printf("\n\nEnter data:\n");
		scanf("%d",&q->data);
		
		q->next=NULL;
		p->next=q;
		p=q;
		
		printf("\nMore(Y/N):\n");
		//scanf("%c",&ch);
		ch = getche();
	}
	return head;
}

void traverse(node *h)
{
	printf("\n\nData:\n");
	while(h!=NULL)
	{
		printf("%d\n",h->data);
		h=h->next;
	}
}

node *ins_first(node *h)
{
	node *q;
	q = (node *)malloc(sizeof(node));
	printf("\nEnter data:\n");
	scanf("%d",&q->data);
	q->next=NULL;
	q->next=h;
	h=q;
	return h;	
}

int main()
{
	node *head;
	head=create();
	traverse(head);
	head=ins_first(head);
	traverse(head);
	return 0;
}