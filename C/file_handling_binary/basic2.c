// WAP in C to read all record of a details of student from a binary file:

#include <stdio.h>
struct student
{
    int rollno;
    char nm[20],cs[10];
    float fee;
};
void main()
{
    struct student s;
    FILE *fp;
    fp=fopen("std.bin","rb");
    if(fp==NULL)
    printf("File not found");
    else
    {
        printf("Roll_no\tName\tCourse\tFee");
        while(fread(&s,sizeof(s),1,fp)==1)
        {
            printf("\n%d\t%s\t%s\t%.2f",s.rollno,s.nm,s.cs,s.fee);
        }
    }
    fclose(fp);

}