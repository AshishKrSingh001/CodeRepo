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
	h = (node *)malloc(sizeof(node));
	printf("\nEnter data:\n");
	scanf("%d",&h->data);
	h->next=h;
	char ch;
	printf("\nMore(Y/N): ");
	ch = getche();
	p=h;
	while(ch!='n' && ch!='N')
	{
		q = (node *)malloc(sizeof(node));
		printf("\nEnter data:\n");
		scanf("%d",&q->data);
		q->next=h;
		p->next=q;
		p=q;
		printf("\nMore(Y/N): ");
		ch = getche();
	}
	return h;
}

void show(node *h)
{
	node *p;int i;
	printf("\nPosition:\tData:\tAddress:\tNext:\n");
	for(i=1,p=h;p->next!=h;i++,p=p->next)
	{
		printf("%d:\t\t%d\t%d\t\t%d\n",i,p->data,p,p->next);
	}
	printf("%d:\t\t%d\t%d\t\t%d\n",i,p->data,p,p->next);
}

node *insert_first(node *h)
{
	node *p,*q;
	q = (node*)malloc(sizeof(node));
	printf("\nEnter data for insert at first position: \n");
	scanf("%d",&q->data);
	q->next=h;
	for(p=h;p->next!=h;p=p->next);
	p->next=q;
	return q;
}

node *insert_last(node *h)
{
	node *p,*q;
	q = (node*)malloc(sizeof(node));
	printf("\nEnter data for insert at last position:\n");
	scanf("%d",&q->data);
	q->next=h;
	for(p=h;p->next!=h;p=p->next);
	p->next=q;
	return h;
}

node *insert_before_position(node *h)
{
	node *p, *q;
	int pos,i;
	printf("\nEnter Position no where you want to insert data:\n");
	scanf("%d",&pos);
	for(i=1,p=h;p->next!=h;p=p->next,i++);
	if(i+1<pos)
	{
		printf("\nInvalid position\n");
		return h;
	}
	q = (node*)malloc(sizeof(node));
	printf("\nEnter data for specified position:\n");
	scanf("%d",&q->data);
	if(pos==1)
	{
		q->next=h;
		p->next=q;
		return q;
	}
	for(p=h,i=1;i<pos-1;i++,p=p->next);
	q->next=p->next;
	p->next=q;
	return h;
}

node *insert_after_position(node *h)
{
	node *p,*q;
	int pos,i;
	printf("\nEnter position no after that you want to insert data:\n");
	scanf("%d",&pos);
	for(p=h,i=1;p->next!=h;p=p->next,i++);
	if(i<pos)
	{
		printf("\nInvalid position no!\n");
		return h;
	}
	q = (node*)malloc(sizeof(node));
	printf("\nEnter data after specified position: \n");
	scanf("%d",&q->data);
	if(pos==1)
	{
		q->next=h->next;
		h->next=q;
		return h;
	}
	for(i=1,p=h;i<pos;i++,p=p->next);
	q->next=p->next;
	p->next=q;
	return h;
}

node *delete_first(node *h)
{
	node *p;
	for(p=h;p->next!=h;p=p->next);
	p->next=h->next;
	free(h);
	return p->next;
}
node *delete_last(node *h)
{
	node *p,*q;
	for(p=h;p->next->next!=h;p=p->next);
	q=p->next;
	p->next=h;
	free(q);
	return h;
	
}

node *delete_position(node *h)
{
	node *p,*q;
	int pos,i;
	printf("\nEnter position that you want to delete:\n");
	scanf("%d",&pos);
	for(p=h,i=1;p->next!=h;p=p->next,i++);
	if(i<pos || pos<=0)
	{
		printf("\nInvalid position!\n");
		return h;
	}
	if(pos==1)
	{
		p->next=h->next;
		free(h);
		return p->next;
	}
	for(i=1,p=h;i<=pos-2;i++,p=p->next);
	q=p->next;
	p->next=q->next;
	free(q);
	return h;
}

node *concatnate(node *h1,node *h2)
{
	node *p;
	for(p=h1;p->next!=h1;p=p->next);
	p->next=h2;
	for(p=h2;p->next!=h2;p=p->next);
	p->next=h1;
	return h1;
}

node *sort(node *h)
{
	node *p,*q;int temp;
	for(p=h;p->next!=h;p=p->next)
	{
		for(q=p->next;q!=h;q=q->next)
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
	node *p,*q,*r;
	p=h->next;
	q=h;
	r=h;
	while(p!=h)
	{
		q=p;
		p=p->next;
		q->next=r;
		r=q;
	}
	p->next=q;
	return q;
}

node *delete_duplicate(node *h)
{
	node *p,*q,*r;
	for(p=h;p->next!=h;p=p->next)
	{
		for(q=p;q->next!=h;q=q->next)
		{
			if(p->data == q->next->data)
			{
				r = q->next;
				q->next = q->next->next;
				free(r);
			}
		}
		if(p->data == q->next->data)
		{
			r = q->next;
			q->next = q->next->next;
			free(r);
		}
	}
	return h;
}

void choose()
{
	node *z;
	z=create();
	show(z);
	char ch;
	do
	{
		printf("\nMENU:\nA: Insert data at first\nB: Insert data at last\nC: Insert data at specified position\nD: Insert data after specified position\nE: Delete first data\nF: Delete last data\nG: delete data at specified position\nH: Concatnate two list\nI: Sorting\nJ: Reverse\nK: Delete duplicate\n-> ");
		ch=getche();
		switch(ch)
		{
			case 'A':
			case 'a':
			z=insert_first(z);
			printf("\nLinked-List after inserting data at first position:");
			break;
			case 'B':
			case 'b':
			z=insert_last(z);
			printf("\nLinked-List after inserting data at last position:");
			break;
			case 'C':
			case 'c':
			z=insert_before_position(z);
			printf("\nLinked-List after inserting data at specified position:");
			break;
			case 'D':
			case 'd':
			z=insert_after_position(z);
			printf("\nLinked-List after inserting data after specified position:");
			break;
			case 'E':
			case 'e':
			z=delete_first(z);
			printf("\nLinked-List after deleting data at first position:");
			break;
			case 'F':
			case 'f':
			z=delete_last(z);
			printf("\nLinked-List after deleting data at last position:");
			break;
			case 'G':
			case 'g':
			z=delete_position(z);
			printf("\nLinked-List after deleting data at specified position:");
			break;
			case 'H':
			case 'h':
			node *y;
			y=create();
			show(y);
			z=concatnate(z,y);
			printf("\nLinked-List after concatnating new Linked-list at last position:");
			break;
			case 'I':
			case 'i':
			z=sort(z);
			printf("\nLinked-List after sorting in ascending order:");
			break;
			case 'J':
			case 'j':
			z=reverse(z);
			printf("\nLinked-List in reverse:");
			break;
			case 'k':
			case 'K':
			z=delete_duplicate(z);
			printf("\nLinked-List after deleting duplicate data:");
			break;
			default:
			printf("\nplease enter a valid option\n");		
		}
		show(z);
		printf("\nGo back to MENU(y/n): ");
		ch=getche();
	}while(ch=='Y' || ch=='y');
}



int main()
{
	choose();
	return 0;
}
