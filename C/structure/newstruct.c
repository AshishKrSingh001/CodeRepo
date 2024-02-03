#include <stdio.h>

struct Student
{
    int rollno;
    char name[20];
    char email[100];

    struct Course{
        int cs_id;
        char cs_name;
        char cs_duration;
        float fee;
    } cs = {1, "BCA", "3 Years", 400000.00};

} s = {10, "xyz", "abc@box.com"};


void main(){

    printf("Roll no = %d \n Name = %s \n
    course id=%d\n course name=%s\n course duration=%s\n fee=%f\n", s.rollno,s.name,s.cs.cs_id,s.cs.cs_name,s.cs.cs_duration,s.cs.fee
    );
}