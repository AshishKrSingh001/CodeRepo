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
	node *h,*p,*q;
	h=(node*)malloc(sizeof(node));
	printf("\nWelcome to Linked-list\nPlease create a list\nEnter Data:\n");
	scanf("%d",&h->data);
	h->next=NULL;
	p=h;
	char ch;
	printf("\nMore Data(y/n): ");
	ch=getche();
	while(ch!='n' || ch!='n')
	{
		q=(node*)malloc(sizeof(node));
		printf("\nEnter Data:\n");
		scanf("%d",&q->data);
		q->next=NULL;
		p->next=q;
		p=p->next;
		printf("\nMore Data(y/n): ");
		ch=getche();
	}
	return h;
}

void show(node *a)
{
	printf("\nData:\n");
	while(a!=NULL)
	{
		printf("%d\t",a->data);
		a=a->next;
	}
}
node *insert_first(node *h)
{
	node *n;
	n = (node*)malloc(sizeof(node));
	printf("\nEnter data you want to insert at first:\n");
	scanf("%d",&n->data);
	n->next=h;
	return n;
}
node *insert_last(node *h)
{
	node *n,*p;
	n = (node*)malloc(sizeof(node));
	printf("\nEnter data that you want to enter at last:\n");
	scanf("%d",&n->data);
	n->next=NULL;
	p=h;
	while(p->next!=NULL)
	p=p->next;
	p->next=n;
	return h;
}
node *insert_after_position(node *h)
{
	node *n,*p;
	n=(node*)malloc(sizeof(node));
	printf("\nEnter data that you want to enter after position:\n");
	scanf("%d",&n->data);
	n->next=NULL;
	int pos,c;
	printf("\nEnter position:\n");
	scanf("%d",&pos);
	if(pos<=0)
	{
		printf("\nInvalid position\n");
		return h;
	}
	for(c=1,p=h;c<pos;c++,p=p->next);
	n->next=p->next;
	p->next=n;
	return h;
}

node *insert_before_position(node *h)
{
	node *n,*p;
	n = (node*)malloc(sizeof(node));
	printf("\nEnter data that you want to insert at position:\n");
	scanf("%d",&n->data);
	n->next=NULL;
	int pos,i;
	printf("\nEnter position:\n");
	scanf("%d",&pos);
	if(pos<=0)
	{
		printf("\nInvalid position\n");
		return h;
	}
	if(pos==1)
	{
		n->next=h;
		return n;
	}
	for(i=1,p=h;i<pos-1;i++,p=p->next);
	n->next=p->next;
	p->next=n;
	return h;
}
node *delete_first(node*h)
{
	node *p;
	p=h;
	h=h->next;
	free(p);
	return h;
}
node *delete_last(node*h)
{
	node *p,*q;
	for(p=h;p->next->next!=NULL;p=p->next);
	q=p->next;
	p->next=NULL;
	free(q);
	return h;
}
node *delete_position(node *h)
{
	node *p,*q;
	int i,pos;
	printf("\nEnter position of node that you want to delete:\n");
	scanf("%d",&pos);
	if(pos<=0)
	{
		printf("\nInvalid position\n");
		return h;
	}
	if(pos==1)
	{
		p=h;
		h=h->next;
		free(p);
		return h;
	}
	for(i=1,p=h;i<pos-1;i++,p=p->next);
	q=p->next;
	p->next=p->next->next;
	free(q);
	return h;
}
node *concatnate(node*x,node*y)
{
	node*p;
	for(p=x;p->next!=NULL;p=p->next);
	p->next=y;
	return x;
}

node *sort(node *h)
{
	node *p,*q;
	int temp;
	for(p=h;p->next!=NULL;p=p->next)
	{
		for(q=p->next;q!=NULL;q=q->next)
		{
			if(p->data > q->data)
			{
				temp = p->data;
				p->data = q->data;
				q->data = temp;
				
			}
		}
	}
	return h;
}
node *reverse(node *h)
{
	node *p,*q;
	p=h->next;
	q=h;
	h->next=NULL;
	while(p!=NULL)
	{
		q=p;
		p=p->next;
		q->next=h;
		h=q;
	}
	return q;
}

void choose()
{
	node *z;
	z=create();
	show(z);
	char ch;
	do
	{
		printf("\nEnter:\nA: Insert data at first\nB: Insert data at last\nC: Insert data at specified position\nD: Insert data after specified position\nE: Delete first data\nF: Delete last data\nG: delete data at specified position\nH: Concatnate two list\nI: Sorting\nJ: Reverse\n-> ");
		ch=getche();
		switch(ch)
		{
			case 'A':
			case 'a':
			z=insert_first(z);
			break;
			case 'B':
			case 'b':
			z=insert_last(z);
			break;
			case 'C':
			case 'c':
			z=insert_before_position(z);
			break;
			case 'D':
			case 'd':
			z=insert_after_position(z);
			break;
			case 'E':
			case 'e':
			z=delete_first(z);
			break;
			case 'F':
			case 'f':
			z=delete_last(z);
			break;
			case 'G':
			case 'g':
			z=delete_position(z);
			break;
			case 'H':
			case 'h':
			node *y;
			y=create();
			show(y);
			z=concatnate(z,y);
			break;
			case 'I':
			case 'i':
			z=sort(z);
			break;
			case 'J':
			case 'j':
			z=reverse(z);
			break;
			default:
			printf("\nplease enter a valid option\n");		
		}
		show(z);
		printf("\nMore choice(y/n): ");
		ch=getche();
	}while(ch=='Y' || ch=='y');
}

int main()
{
	choose();
	
	return 0;
	
}