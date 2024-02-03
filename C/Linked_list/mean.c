#include <stdio.h>
#include <conio.h>
#include <malloc.h>

typedef struct node
{
	double X,f;
	struct node *next,*prev;	
}node;

node *create()
{
	node *h,*p,*q;
	h = (node*)malloc(sizeof(node));
	printf("\nEnter value of X: ");
	scanf("%lf",&h->X);
	printf("Enter value of frequency(f): ");
	scanf("%lf",&h->f);
	h->next=NULL;
	h->prev=NULL;
	
	char ch;
	printf("\nMore(Y/N): ");
	ch = getche();
	
	for(p=h;ch !='N' && ch !='n';p=p->next)
	{
		q = (node*)malloc(sizeof(node));
		printf("\n\nEnter value of X: ");
		scanf("%lf",&q->X);
		printf("Enter value of frequency(f): ");
		scanf("%lf",&q->f);
		q->next=NULL;
		p->next=q;
		q->prev=p;
		printf("\nMore(Y/N): ");
		ch = getche();
	}
	return h;
}
void show(node *h)
{
	printf("\nPosition:\tX:\t\tf:\t\tAddress:\t\tPrevious:\t\tNext:\n");
	for(int i=1;h != NULL;h=h->next,i++)
	{
		printf("%d:\t\t%.2lf\t\t%.0lf\t\t%d\t\t%d\t\t%d\n",i,h->X,h->f,h,h->prev,h->next);
	}
}

double mean(node *h)
{
	double sigma_f=0,sigma_fx=0,mean;
	for(int i=1;h != NULL;h=h->next,i++)
	{
		sigma_f = sigma_f + h->f;
		sigma_fx = sigma_fx + (h->f * h->X);
	}
	//mean=sigma_fx/sigma_f;
	return sigma_fx/sigma_f;
}

int main()
{
	node *h;
	h = create();
	show(h);
	h = sort(h);
	show(h);
	//printf("\nMean: %.2lf",mean(h));
	return 0;
}