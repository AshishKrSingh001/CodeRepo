// WAP in C to input Roll_no, Name, Course and Fee for multiple student from console after that write these record.
#include <stdio.h>
void main()
{
    FILE *fp;
    
    int roll_no;
    char nm[20],cs[10];
    float fee;

    char choice;
    fp=fopen("Std_info.dat","a");
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

}