/*
    Difference between Structure & Union

    1.Structure is declered with the help of struct keyword but union is declered with the help of union keyword.
    2.In structure we can access all member of structure at a time but in union we can access only one member at a time.
    3.The size of structure is sum of all members but the size of union is maximum size of member.
    4.Memory will be allocated for all members in structure but in union memory will be allocated for one member that has maximum size.
    5.Structure is mostly used in program but union is rarely used in program.
*/


#include <stdio.h>

union student
{
    int roll_no;
    char name[20];
    float fee;
};

void main()
{
    union student s;
    printf("Enter Roll_no, Name, Fees:\n");
    scanf("%d%s%f",&s.roll_no,s.name,&s.fee);
    printf("Roll_no=%d\nName=%d\nFees=%.2f",s.roll_no,s.name,s.fee);

}