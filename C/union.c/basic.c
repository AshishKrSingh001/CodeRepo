/*
 Union:
    1.It is a collection of different type of data like structure.
    2.It provides user defined datatypes.
    3.We can access only one member of union at a time.
    4.The size of union is equivalent to the size of maximum member of union.
    5.Its main object is to save memory.
    6.It is rarely used in game application.
    7.It is created with the help of union keyword.


    Syntax:
        union <union_name>
        {
            <datatype1> <member1>,<member2>------<membern>
            <datatype2> <member1>,<member2>------<membern>
            ---------------------------
            <datatypen> <member1>,<member2>------<membern>

        }[union_var];


    Example:
        union student
        {
            int roll_no;
            char name[20];
            float fee;
        }u;
*/

//Implementation
#include <stdio.h>
#include <string.h>

union student
{
    int roll_no;
    char name[20];
    float fee;
};

void main()
{
    union student s;
    printf("Enter Roll_no:\n");
    scanf("%d",&s.roll_no);
    printf("Roll no: %d",s.roll_no);

    printf("\nEnter Name:\n");
    scanf("%s",s.name);
    printf("Name: %s",s.name);

    printf("\nEnter fees:\n");
    scanf("%f",&s.fee);
    printf("Fees: %f",s.fee);
}
