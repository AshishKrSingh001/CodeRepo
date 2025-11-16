#include <stdio.h>
#include <malloc.h>
#include <conio.h>
#define size 10

// int s[], int top=-1;

void push(int s[], int *top, int data)
{
	if(*top>=size)
	{
		printf("\nStack is full!\n");
		return;
	}
	*top++;
	s[*top]=data;
}

void peep(int s[], int *top)
{
	if(*top==-1)
	{
		printf("\nStack is empty!\n");
        return;
	}
    printf("\n%d",s[*top]);
}
void displayStack(int s[], int *top)
{
	if(*top==-1)
	{
		printf("\nStack is empty!\n");
        return;
	}
	printf("\nData:\n");
	for(int i=(*top);i>=0;i--)
	{
		printf("%d\t",s[i]);
	}
}

void pop(int s[], int *top)
{
	if((*top)==-1)
	{
		printf("\nStack is empty!\n");
        return;
	}
	(*top)--;
}

int main()
{
    int s1[size],top1=-1;
    int s2[size],top2=-1;
    printf("\nStack is empty!\n");
    
    push(s1, &top1, 1);push(s1, &top1, 2);push(s1, &top1, 3);
     printf("\nStack is empty!\n");
    
    // push(s2, &top2, 11);push(s2, &top2, 22);push(s2, &top2, 33);
 printf("\nStack is empty!\n");
    displayStack(s1,&top1);
    // displayStack(s2,&top2);
    printf("\nStack is empty!\n");
}