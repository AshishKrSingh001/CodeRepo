#include <stdio.h>
#include <conio.h>
#include <malloc.h>
typedef struct file
{
	int ak;
	struct file *next;
	
}file;
file *made()
{
	file *h,*p,*c;
	h=(file*)malloc(sizeof(file));
	printf("\nEnter numer:\n");
	scanf("%d",&h->ak);
	h->next=NULL;
	p=h;
	char ch;
	printf("\nMore(y/n):");
	ch=getche();
	while(ch=='y'|| ch=='Y')
	{
	c=(file*)malloc(sizeof(file));
	printf("\nEnter numer:\n");
	scanf("%d",&c->ak);
	c->next=NULL;
	p->next=c;
	p=p->next;
	printf("\nMore(y/n):");
	ch=getche();
	}
	return h;
}
void show (file *h)
{
	printf("\nData\n");
	while(h!=NULL)
	{
		printf("%d\n",h->ak);
		h=h->next;
		
	}
}
int main()
{
	file *p;
	p=made();
	show(p);
}