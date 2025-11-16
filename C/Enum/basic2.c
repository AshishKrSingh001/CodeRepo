#include<stdio.h>
typedef enum color
{
    red=4,
    green=8,
    blue=5,
    orange,
} color;
//enum color {red=4,green =8,blue=5};
enum name{aaa,bbb,ccc,ddd,eee};
void main()
{
    //enum color c; //enumeration variable
    color c;   //enumeration variable
    enum name nm;  //enumeration variable
    //int rs1,rs2;
    c=red+green+blue+orange;
    nm=aaa+bbb;
    printf("Value of rs1 = %d\nValue of rs2 = %d\n",c,nm);
    printf("%d",orange);
}