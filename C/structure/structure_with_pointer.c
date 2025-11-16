#include <stdio.h>

struct student
{
    int id,fees;
    char name[20],course[10];
};

void main()
{
    
    int i,n;
    
    printf("Enter no of student:\n");
    scanf("%d",&n);
    struct student s[n];

    printf("Enter NAME, COURSE,ID, FEES of a %d student:\n",n);
    for(i=0;i<n;i++)
    {
        printf("student %d\n",i+1);
        printf("NAME: ");
        //gets(s[i].name);
        scanf("%s",s[i].name);
        printf("ID: ");
        scanf("%d",&s[i].id);
        printf("COURSE: ");
        //gets(s[i].course);
        scanf("%s",s[i].course);
        printf("FEES: ");
        scanf("%d",&s[i].fees);
    }
    
    
    for(i=0;i<n;i++)
    printf("Details of student %d\nID=%d\tNAME=%s\tCOURSE=%s\tFEES=%d\n\n",i+1,s[i].id,s[i].name,s[i].course,s[i].fees);

    printf("\n\n\n");
    struct student *p;
    p=&s[2];
    printf("Details of student 2\nID=%d\tNAME=%s\tCOURSE=%s\tFEES=%d\n\n",i+1,*p.id,*p.name,*p.course,*p.fees);
}