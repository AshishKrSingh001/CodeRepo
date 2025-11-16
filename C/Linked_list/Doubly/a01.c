#include <stdio.h>
#include <conio.h>
#include <malloc.h>
//We have to create a structure which store data and two addresses;
typedef struct node
{
	// Here data-> represents value, next-> represents address of next node and prev-> represents address of previous node;
	int data;
	struct node *next,*prev;
	
}node;
//Here structure name is node and structure variable name is alse node;

//create() function will create a Linked-list and return address of first node;
node *create()
{
	node *p,*q,*h;
	// Here h-> is used for creating first node and storing the address of first node;
	// p-> is used for moving; 
	// q-> is used for creating node after first node;
	h=(node *)malloc(sizeof(node));
	printf("\nWelcome to Linked-list\nPlease create a list\nEnter Data:\n");
	scanf("%d",&h->data);
	h->next=NULL;
	h->prev=NULL;
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
		q->prev=p;
		p->next=q;
		p=p->next;
		printf("\nMore Data(y/n): ");
		ch=getche();
	}
	return h;
}

void show(node *a)
{
	int i;
	printf("\nFirst to last\nPosition:\tData:\t\tPrevious:\tSelf\t\tNext:");
	for(i=1;a->next!=NULL;i++)
	{
		printf("\n%d:\t\t%d\t\t%d\t\t%d\t\t%d",i,a->data,a->prev,a,a->next);
		a=a->next;
	}
	printf("\n%d:\t\t%d\t\t%d\t\t%d\t\t%d",i,a->data,a->prev,a,a->next);
	printf("\n\nLast to First\nPosition:\tData:\t\tPrevious:\tSelf\t\tNext:");
	for(i=i;a!=NULL;i--)
	{
		printf("\n%d:\t\t%d\t\t%d\t\t%d\t\t%d",i,a->data,a->prev,a,a->next);
		a=a->prev;
	}
	printf("\n");
}

//insert_first() function will insert a node in Linked-list at first position and return address of first node;
node *insert_first(node *h)
{
	node *n,*p;
	n=(node *)malloc(sizeof(node));
	printf("\nEnter data that you want to insert at first:\n");
	scanf("%d",&n->data);
	n->next=h;
	n->prev=NULL;
	h->prev=n;
	return n;	
}

//insert_last() function will insert a node in Linked-list at last position and return address of first node;
node *insert_last(node *h)
{
	node *n,*p;
	n=(node *)malloc(sizeof(node));
	printf("\nEnter data that you want to insert at first:\n");
	scanf("%d",&n->data);
	n->next=NULL;
	n->prev=NULL;
	for(p=h;p->next!=NULL;p=p->next);
	p->next=n;
	n->prev=p;
	return h;
}

//insert_before_position() function will insert a node in Linked-list at specified position and return address of first node;
node *insert_before_position(node *h)
{
	int pos,i;
	printf("\nEnter position where you want to store the data:\n");
	scanf("%d",&pos);
	node *n,*p;
	for(p=h,i=1;p->next!=NULL;p=p->next,i++);
	if(pos<=0 || pos>1+i)
	{
		printf("\nInvalid Position\n");
		return h;
	}
	n=(node *)malloc(sizeof(node));
	printf("\nEnter data that you want to store at specified position:\n");
	scanf("%d",&n->data);
	n->next=NULL;
	n->prev=NULL;
	if(pos==1)
	{
		n->next=h;
		h->prev=n;
		return n;
	}
	if(pos==i+1)
	{
		p->next=n;
		n->prev=p;
		return h;
	}
	for(p=h,i=1;i<=pos-2;p=p->next,i++);
	n->next=p->next;
	p->next->prev=n;
	p->next=n;
	n->prev=p;
	return h;
}

//insert_after_position() function will insert a node in Linked-list after specified position and return address of first node;
node *insert_after_position(node *h)
{
	int pos,i;
	printf("\nEnter position after you want to store the data:\n");
	scanf("%d",&pos);
	node *p,*n;
	for(p=h,i=1;p->next!=NULL;p=p->next,i++);
	if(pos<=0 || pos>i)
	{
		printf("\nInvalid Position\n");
		return h;
	}
	n = (node *)malloc(sizeof(node));
	printf("\nEnter data that you want to enter after specified position:\n");
	scanf("%d",&n->data);
	n->next=NULL;
	n->prev=NULL;
	if(pos==i)
	{
		p->next=n;
		n->prev=p;
		return h;
	}
	for(p=h,i=1;i<pos;p=p->next,i++);
	n->next=p->next;
	n->prev=p;
	p->next->prev=n;
	p->next=n;
	return h;
}

//delete_first() function will delete a node in Linked-list at first position and return address of first node;
node *delete_first(node *h)
{
	node *p;
	p=h;
	h=h->next;
	h->prev=NULL;
	free(p);
	return h;
}

//delete_last() function will delete a node in Linked-list at last position and return address of first node;
node *delete_last(node *h)
{
	node *p,*q;
	for(p=h;p->next->next!=NULL;p=p->next);
	q=p->next;
	p->next=NULL;
	free(q);
	return h;
}

//delete_position() function will delete a node in Linked-list at specified position and return address of first node;
node *delete_position(node *h)
{
	int pos,i;
	printf("\nEnter the position that you want to delete:\n");
	scanf("%d",&pos);
	node *p,*q;
	for(p=h,i=1;p->next->next!=NULL;p=p->next,i++);
	if(pos<=0 || pos>i+1)
	{
		printf("\nInvalid Position\n");
		return h;
	}
	if(pos==1)
	{
		p=h;
		h=h->next;
		h->prev=NULL;
		free(p);
		return h;
	}
	if(pos==i+1)
	{
		q=p->next;
		p->next=NULL;
		free(q);
		return h;
	}
	for(p=h,i=1;i<pos-1;p=p->next,i++);
	q=p->next;
	p->next=p->next->next;
	p=q->next;
	p->prev=q->prev;
	free(q);
	return h;
}

//concatnate() function will concate two Linked-list and return address of first node;
node *concatnate(node *h1,node *h2)
{
	node *p;
	for(p=h1;p->next!=NULL;p=p->next);
	p->next=h2;
	h2->prev=p;
	return h1;
}

node *sort(node *h)
{
	node *p,*q;
	for(p=h;p->next!=NULL;p=p->next)
	{
		for(q=p->next;q!=NULL;q=q->next)
		{
			if(p->data > q->data)
			{
				int data = p->data;
				p->data = q->data;
				q->data = data;
			}
		}
	}
	return h;
} 
//reverse() function will reverse the linked list and return address of first node;
node *reverse(node *h)
{
	node *p,*q;
	p=h->next;
	q=h;
	q->next=NULL;
	while(p!=NULL)
	{
		q->prev=p;
		q=p;
		p=p->next;
		q->next=h;
		h=q;
	}
	h->prev=NULL;
	return h;
}
//delete_duplicate() function will delete the duplicate value's node and return address of first node;
node *delete_duplicate(node *h)
{
	node *p,*q;
	for(p=h;p->next!=NULL;p=p->next)
	{
		for(q=p->next;q!=NULL;q=q->next)
		{
			if(p->data == q->data)
			{
				node *z;
				z=q;
				q=q->prev;
				q->next = z->next;
				z->next->prev = q;
				free(z);
			}
		}
	}
	return h;
}

//choose() function will used for switch case;
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
}
