#include <stdio.h>

struct DOB
{
    int dd,mm,yyyy;
};

struct Survey
{
    char gen[10],nm[20],mob[10],aadhar[12],occu[20],mar[10];
    int sal,age;
    struct DOB dob;
    struct family
    {
        char fnm[20],mnm[20];
    }f;
}s;


int age(int y)
{
    return (2023-y);
}

// WAP in C to input Roll_no, Name, Course and Fee for multiple student from console after that write these record.
#include <stdio.h>
void main()
{
    FILE *fp;
    
    int roll_no;
    char nm[20],cs[10];
    float fee;

    char choice;
    fp=fopen("myinfo.txt","w");
     printf("Enter your Name:\n");
    gets(s.nm);
    printf("Enter your Father's Name:\n");
    gets(s.f.fnm);
    printf("Enter your Mother's Name:\n");
    gets(s.f.mnm);
    printf("Enter Date of Birth(Date, Month, Year respectively):\n");
    scanf("%d%d%d",&s.dob.dd,&s.dob.mm,&s.dob.yyyy);
    fflush(stdin);
    printf("Are you married (Y:yes/N:no):\n");
    gets(s.mar);
    fflush(stdin);
    printf("Enter your Gender(M:male/F:female/O:other):\n");
    gets(s.gen);
    fflush(stdin);
    printf("Enter your Mob.no:\n");
    gets(s.mob);
    printf("Enter your Aadhar.no:\n");
    gets(s.aadhar);
    printf("Enter your Occupation:\n");
    gets(s.occu);
    printf("Enter your salary:\n");
    scanf("%d",&s.sal);
    

    
    fprintf(fp,"Name: %s\nFather's Name: %s\nMother's Name: %s\nDate of Birth=%d-%d-%d\nAge=%d\nMarried: %s\nGender: %s\nMobile no: %s\nAadhar no: %s\nOccupation: %s\nSalary: %d",s.nm,s.f.fnm,s.f.mnm,s.dob.dd,s.dob.mm,s.dob.yyyy,age(s.dob.yyyy),s.mar,s.gen,s.mob,s.aadhar,s.occu,s.sal);
    
    fclose(fp);

}






   