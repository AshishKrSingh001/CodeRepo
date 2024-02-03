#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

typedef struct node
{
	int data;
	struct node *left,*right;
}node;

node* newNode(int val)
{
    node* newNode = (node*)malloc(sizeof(node));
    newNode->data = val;
    newNode->left = newNode->right = NULL;
    return newNode;
}

node* insert(node *node,int val)
{
	if(node == NULL)
	{
		return newNode(val);
	}
	
	if(val <= node->data)
	{
	    node->left = insert(node->left,val);
	}
	else if(val > node->data)
	{
	    node->right = insert(node->right,val);
	}
	return node;
}

void printInorder(node *node)
{
	if(node == NULL)
	{
		return;
	}
	printInorder(node->left);
	
	printf("%d%5d%12d%12d\n",node,node->data,node->left,node->right);
	
	printInorder(node->right);
}

void printPreorder(node *node)
{
	if(node == NULL)
	{
		return;
	}
	printf("%d%5d%12d%12d\n",node,node->data,node->left,node->right);
	
	printInorder(node->left);
	
	printInorder(node->right);
}

void printPostorder(node *node)
{
	if(node == NULL)
	{
		return;
	}
	printInorder(node->left);
	
	printInorder(node->right);
	
	printf("%d%5d%12d%12d\n",node,node->data,node->left,node->right);
}

int main()
{
	node *node;
	int val;char ch;
	node = insert(node,10);
	node = insert(node,100);
	node = insert(node,1000);
    do
    {
        puts("\nEnter data: ");
        scanf("%d",&val);
        node = insert(node,val);
        printf("\nMore(Y/N): ");
        ch = getche();
    }while(val !=0 && val != 0);
    
	puts("\nInorder Travarsal\n\nAddress\t Data\t\tLeft\t\tRight");
	printInorder(node);
	puts("\nPreorderTravarsal\n\nAddress\t Data\t\tLeft\t\tRight");
	printPreorder(node);
	puts("\nPostorderTravarsal\n\nAddress\t Data\t\tLeft\t\tRight");
	printPostorder(node);
	return 0;
}