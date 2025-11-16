// WAP in c to create a structure as named student to input roll no and name of more students after that print all records.Implement malloc function.

#include <stdio.h>

struct student
{
    int roll;
    char nm[20];
};

void main()
{
    int n,i;
    printf("Enter size of record:\n");
    scanf("%d%d",&n);
    struct student *p;
    p=(struct student *)malloc(sizeof(struct student )*n);
    
    for(i=0;i<n;i++)
    {
        printf("Enter Roll_no & Name of %d student:\n");
        scanf("%d%s",(P+i)->roll,(p+i)->nm);
    }

    for(i=0;i<n;i++)
    {
        printf("\nRoll_no & Name of %d student:\n");
        scanf("%d%s",*(P+i)->roll,*(p+i)->nm);
    }

}