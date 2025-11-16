/*
    fprintf():This function is used to write formatted data in a file

        syntax:
            void fprintf(<file pointer>,<Format specifier>,<variables name>);

        Example:
            int rollno=10;
            char nm[20]="XYZ";
            char cs[20]="BCA";
            float fee=6000;
            fprintf(fp,"%d\t%s\t%s\t%f\t",rollno,nm,cs,fee);

    fscanf():This function is used to read formatted data from a file.
        Syntax:
            void fscanf(<file pointer>,"Formatted seperator",&<variable name>);

        Example:
            int rollno;
            char n[20],cs[20];
            float fee;

            fscanf(fp,"%d%s%s%f",&rolno,nm,cs,&fee);
*/
// Name: Abhishek Kumar 
// Y24271002
// WAP for data record.
#include <stdio.h>
void main()
{
    FILE *fp;
    int rollno = 10;
    char nm[20] = "XYZ";
    char cs[20] = "BCA";
    float fee = 6000;
    fp = fopen("my_info.txt", "w");
    fprintf(fp,"%d\t%s\t%s\t%f\t",rollno,nm,cs,fee);
    fclose(fp);
}