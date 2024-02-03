#include <stdio.h>

struct student
{
    int roll;
    char name[10],cs[10];
    float fee;
};

struct student get_input()
{
    struct student s;
    printf("Enter Roll no, Name, Course & Fees:\n");
    scanf("%d%s%s%f",&s.roll,s.name,s.cs,&s.fee);
    return(s);
}
struct student show_record(struct student s)
{
    printf("Enter Roll no: %d\nName: %s\nCourse: %s\nFees: %f\n",s.roll,s.name,s.cs,s.fee);
    
}

void main()
{
    struct student s;
    s=get_input();
    show_record(s);
    
}