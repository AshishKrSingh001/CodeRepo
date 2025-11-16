#include <stdio.h>
#include <string.h>
#include <malloc.h>
/********************Stack for operator************************/
typedef struct node
{
	char data;
	struct node *next; 
}node;
node *top=NULL;
void push(char ch)
{
	node *q;
	q = (node *)malloc(sizeof(node));
	q->data=ch;
	q->next=top;
	top = q;
}
char pop()
{
	char ch;
	node *q;
	q = top;
	top = top->next;
	ch = q->data;
	free(q);
	return ch;
}
void peep()
{
	node *q;
	for(q=top;q!=NULL;q=q->next)
		printf("%c\t",q->data);
}
/******************************End********************************/
int preced(char ch)
{
	int p;
	switch(ch)
	{
		case '+':
		case '-':
			p=1;
			break;
		case '*':
		case '/':
			p=2;
			break;
		case ')':
		case '(':
			p=3;
			break;
	}
	return p;
}
char *infixToPostfix(char*infix,char*postfix)
{
	char ch;
	int i,c=0;
	for(i=0;i<strlen(infix);i++)
	{
		if(infix[i] == '*' || infix[i] == '/' || infix[i] == '+' || infix[i] == '-' || infix[i] == '(' || infix[i] == ')')
		{
			if(top == NULL)
			{
				push(infix[i]);
			}
			else if(infix[i] == '(')
			{
				push(infix[i]);
			}
			else if(infix[i] == ')')
			{
				while(true)
				{
					ch == pop();
					if(ch == '(')
					{
						break;
					}
					postfix[c++]=infix[i];
				}
			}
			else if(top != NULL && top->data == '(')
			{
				push(infix[i]);
			}
			else if(top != NULL && top->data != '(')
			{
				if(preced(top->data)>preced(infix[i]))
				{
					ch == pop();
					postfix[c++]=ch;
				}
				else
				{
					push(infix[i]);
				}
			}
		}
		else
		{
			postfix[c++]=infix[i];
		}
	}
	while(top != NULL)
	{
		ch = pop();
		postfix[c++]=ch;
	}
	return postfix;
}


int main()
{
	char postfix[20],infix[20]="a+b+c";
	//puts("\nEnter Infix:");
	//gets(infix);
	int c=0;
	for(int i=0;i<strlen(infix);i++)
	{
		printf("%c\n",infix[i]);
		strncat(postfix, &infix[i], c);
		c++;
	}
	puts(postfix);
	//printf("\nAfter converting Prefix to Infix\n%s :\t%s\n",infix,infixToPostfix(infix,postfix));
	return 0;
}