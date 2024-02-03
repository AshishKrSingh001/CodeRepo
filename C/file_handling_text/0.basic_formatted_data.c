/*
    1. getc():This function is used to read one character from a file.
        syntax:
            char getc(file pointer);

        example:
            char ch;
            ch=getc(fp);

    2. putc():This fuction is used to write one character in a file.
        syntax:
            void putc(char.value,file pointer);

        example: 

        These function is unformated input operation(Doesn't use format specifier)
        getch():Not visible in console and doesn't require to press enter key
        getche():Visble in console and doesn't require to press enter key
        getchar():Visble in console and require to press enter key
*/

// WAP in C to input Roll_no, Name, Course and Fee for multiple student from console after that write these record.
#include <stdio.h>
void main()
{
    FILE *fp;
    
    int roll_no;
    char nm[20],cs[10];
    float fee;

    char choice;
    fp=fopen("Std_info.txt","a");
    do
    {
        printf("Enter Roll_no, Name, Course & Fees:\n");
        scanf("%d%s%s%f",&roll_no,nm,cs,&fee);

        fprintf(fp,"%d\t%s\t%s\t%f\n",roll_no,nm,cs,fee);
        printf("Do you want to enter more record (Y for yes & N for no): ");
        fflush(stdin);
        scanf("%c",&choice);
    }while(choice=='y' || choice=='Y');
    fclose(fp);
    fp=fopen("Std_info.txt","r");
    fclose(fp);

}