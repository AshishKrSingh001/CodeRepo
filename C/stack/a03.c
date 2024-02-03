#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
typedef struct node
{
    int data;
    struct node *next;
}node;

node *create()
{
    node *head,*p,*q;
    char ch;
    head=(node*)malloc(sizeof(node));
    printf("Enter Data :- ");
    scanf("%d",&head->data);
    head->next=NULL;
    p=head;
    printf("more(y/n)");
    ch=getche();
    while(ch=='y'||ch=='Y')
    {
        q=(node*)malloc(sizeof(node));
        printf("\nEnter Data :- ");
        scanf("%d",&q->data);
        q->next=NULL;
        p->next=q;
        p=q;
        printf("more(y/n)");
        ch=getche();
    }
    return head;
}
void show(node *head)
{
    printf("\nS.No.\tElements\tNext_Address");
    for(int i=1;head!=NULL;i++)
    {
        printf("\n%d\t%d\t\t%d",i,head->data,head->next);
        head=head->next;
    }
}

node *delete01(node *head)
 {printf("a");
	node *p,*q,*t;
     for(p=head;p->next!=NULL;p=p->next)
     {printf("b");
         for(q=p;q->next!=NULL;q=q->next)
         {printf("c");
             if(p->data == q->next->data)
             {printf("d");
                 t = q->next;
                 q->next =  q->next->next;
                 free(t);
             }printf("e");
         }printf("f");
     }printf("g");
    
     printf("\nAfter Deleting Duplicate Elements :- ");
     return head;
 } 

int main()
{
    node *head;
    head = create();
    show(head);

    head = delete01(head);
    show(head);
	return 0;
}