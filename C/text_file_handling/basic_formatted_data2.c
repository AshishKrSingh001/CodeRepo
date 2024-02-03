// WAP in C to read Roll_no, Name, Course and Fee of student after thet print on console.
#include <stdio.h>
void main()
{
    FILE *fp;
    
    int roll_no;
    char nm[20],cs[10];
    float fee;

    char choice;
    fp=fopen("Std_info.dat","r");
    if(fp==NULL)
    printf("File not found");
    else
    {
        printf("Roll_no\tName\tCourse\tfee\n");
        while(fscanf(fp,"%d%s%s%f",&roll_no,nm,cs,&fee)!=EOF)
        printf("%d\t%s\t%s\t%.2f\n",roll_no,nm,cs,fee);

    }
    fclose(fp);

}