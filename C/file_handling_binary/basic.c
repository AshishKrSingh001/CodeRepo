/*
        File mode in binary:
            wb      write in binary file
            rb      Read in binary file
            wb+     Write + Read in binary file
            rb+     Read + write in binary file
            ab+     Append + Read in binary file



        Function used in this:
            1) fwrite();
            2) fread();
            3) seek();
            4) ftell();
            5) rename();
            6) rewind();
            7) remove();

        1) f.write():
            This function is used to write record in binary file by the help of structure.

            Syntax:
                void fwrite(&<structure variable>,<no of record>,<file pointer>);

            Example:
                struct student
                {
                    int rollno;
                    char name[10];
                };
                struct student s;
                fwrite(&s,sizeof(s),fp);


*/

//WAP in C to input roll_no, name, course & marks of 3 subjects after that write these records in binary file.
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
    char choice;
    fp=fopen("std.bin","a+");
    do
    {
        printf("Enter Roll_no, Name, Course & fee of student:\n");
        scanf("%d%s%s%f",&s.rollno,s.nm,s.cs,&s.fee);
        fwrite(&s,sizeof(s),1,fp);

        printf("Do you want to continue (y/n): ");
        fflush(stdin);
        scanf("%c",&choice);
    }while(choice=='y' || choice=='Y');

    fclose(fp);

}