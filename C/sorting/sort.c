#include <stdio.h>
#include <conio.h>

void swap(int *a,int *b);
void selectionSort(int a[],int size);
void bubbleSort(int a[],int size);
void insertionSort(int a[],int size);
int partition(int a[],int min,int max);
void quickSort(int a[],int min,int max);
void mergeSort(int a[],int size1,int b[],int size2,int c[]);
void linearSearch(int a[],int size,int val);
void binarySearch(int a[],int size,int val);

void arrayInput(int a[],int size)
{
	printf("\nEnter %d element of array: \n",size);
	for(int i=0;i<size;i++)
	scanf("%d",&a[i]);
}

void arrayOutput(int a[],int size)
{
	printf("\nArray: \n");
	for(int i=0;i<size;i++)
	printf("%d\t",a[i]);
	printf("\n");
}

int main()
{
	int n,n1,n2,val;
	printf("\nEnter size of array: \n");
	scanf("%d",&n);
	
	int a[n];
	arrayInput(a,n);
	arrayOutput(a,n);
	
	char ch;
	do
	{
		printf("\nA:\tSorting\nB:\tSearching\n->");
		ch = getche();
		switch(ch)
		{
			case 'A':
			case 'a':
				printf("\nEnter\nA:\tSelection Sorting;\nB:\tBubble Sorting;\nC:\tInsertion Sorting;\nD:\tQuick Sorting;\nE:\tMerge Sorting;\n->");
				ch = getche();
				switch(ch)
				{
					case 'A':
					case 'a':
						selectionSort(a,n);
						arrayOutput(a,n);
						break;
					case 'B':
					case 'b':
						bubbleSort(a,n);
						arrayOutput(a,n);
						break;
					case 'c':
					case 'C':
						insertionSort(a,n);
						arrayOutput(a,n);
						break;
					case 'D':
					case 'd':
						quickSort(a,0,n-1);
						arrayOutput(a,n);
						break;
					case 'E':
					case 'e':
						printf("\nEnter size of array: \n");
						scanf("%d",&n2);
						n1=n+n2;
						int b[n2],c[n1];
						arrayInput(b,n2);
						arrayOutput(b,n2);
						selectionSort(a,n);
						arrayOutput(a,n);
						selectionSort(b,n2);
						arrayOutput(b,n2);
						mergeSort(a,n,b,n2,c);
						arrayOutput(c,n1);
						break;
				}
				break;
			
			case 'B':
			case 'b':
				printf("\nEnter\nA:\tLinear Searching;\nB:\tBinary Searching;\n->");
				ch = getche();
				printf("\nEnter Searching value: \n");
				scanf("%d",&val);
				switch(ch)
				{
					case 'A':
					case 'a':
						linearSearch(a,n,val);
						break;
					case 'B':
					case 'b':
						binarySearch(a,n,val);
				}
				break;
				
			case 'q':
			case 'Q':
				ch='q';
				break;
			default:
				printf("\nInvalid choice\n");
			
		}
	}while(ch != 'q' && ch != 'Q');
	return 0;
}

void swap(int *a,int *b)
{
	int temp = *a;
	*a = *b;
	*b = temp;
}
void selectionSort(int a[],int size)
{
	for(int i=0;i<size-1;i++)
	{
		for(int j=i+1;j<size;j++)
		{
			if(a[i] > a[j])
			{
				swap(&a[i],&a[j]);
			}
		}
	}
}

void bubbleSort(int a[],int size)
{
	for(int i=0;i<size-1;i++)
	{
		for(int j=0;j<size-1-i;j++)
		{
			if(a[j] > a[j+1])
			{
				swap(&a[j],&a[j+1]);
			}
		}
	}
}

void insertionSort(int n[],int size)
{
	int i,j,k,t;
	for(i=0;i<=size-2;i++)
	{
		for(j=i+1;j<=size-1;j++)
		{
			if(n[i] > n[size-1])
			{
				t = n[j];
				for(k=j;k>i;k--)
				{
					n[k] = n[k-1];
				}
				n[k] = t;
			}
		}
	}
}

int partition(int n[], int min, int max)
{
	int key = n[max];
	int i = (min - 1);

	for (int j = min; j <= max - 1; j++) 
	{
		if (n[j] < key) 
		{
			i++;
			swap(&n[i], &n[j]);
		}
	}
	swap(&n[i + 1], &n[max]);
	return (i + 1);
}

void quickSort(int a[],int min,int max)
{
	int z;
	if(min <=max)
	{
		z = partition(a,min,max);
		quickSort(a,min,z-1);
		quickSort(a,z+1,max);
	}
}

void mergeSort(int a[],int size1,int b[],int size2,int c[])
{
	int i=0,j=0,k=0;
	while(i<=size1-1 && j<=size2-1)
	{
		if(a[i] <= b[j])
		{
			c[k] = a[i];
			i++;k++;
		}
		if(a[i] > b[j])
		{
			c[k] = b[j];
			j++;k++;
		}
	}
	if(i>=size1)
	{
		while(a[i] > b[j])
		{
			c[k] = b[j];
			j++;k++;
		}
	}
	else
	{
		while(a[i] < b[j])
		{
			c[k] = a[i];
			j++;k++;
		}
	}
}

void linearSearch(int a[],int size,int val)
{
	int flag=0;
	for(int i=0;i<size;i++)
	{
		if(a[i] == val)
		{
			flag=1;
			break;
		}
	}	
	if(flag==1)
	{
		printf("Found");
	}
	else
	{
		printf("Not found");
	}
}

void binarySearch(int a[],int size,int val)
{
	int flag=0,min=0,max=size-1,mid;
	while(min<=max)
	{
		mid = (min+max)/2;
		if(a[mid] > val)
			max = mid - 1;
		if(a[mid] < val)
			min = mid + 1;
		if(a[mid] == val)
		{
			flag=1;
			break;
		}
		
	}
	
	if(flag==1)
	{
		printf("Found");
	}
	else
	{
		printf("Not found");
	}
}
