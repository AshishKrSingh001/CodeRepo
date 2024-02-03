#include <stdio.h>

struct DOB
{
    int dd,mm,yyyy;
};

struct Survey
{
    char gen,nm[20],mob[10],aadhar[12],occu[20],mar;
    int sal,age;
    struct DOB dob;
    struct family
    {
        char fnm[20],mnm[20],wife[20],hs[20],so[10][20],da[10][20];
        int son,dau;
    }f;
};


int age(int y)
{
    return (2023-y);
}


int main()
{
    struct Survey s;
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
    scanf("%c",&s.mar);
    fflush(stdin);
    printf("Enter your Gender(M:male/F:female/O:other):\n");
    scanf("%c",&s.gen);
    if(s.mar=='y' || s.mar=='Y')
    {
        fflush(stdin);
        if(s.gen=='m' || s.gen=='M')
        {
            printf("Enter your Wife's Name:\n ");
            gets(s.f.wife);
        }
        else if(s.gen=='f' || s.gen=='F')
        {
            printf("Enter your Husband's Name:\n ");
            gets(s.f.hs);
        }
        printf("How many Son and Daughter you have(respectively):\n ");
        scanf("%d%d",&s.f.son,&s.f.dau);
        for(int i=0;i<s.f.son;i++)
        {
            fflush(stdin);
            printf("Enter %d Son's Name:\n",i+1);
            gets(s.f.so[i]);
        }
        for(int i=0;i<s.f.dau;i++)
        {
            fflush(stdin);
            printf("Enter %d Daughter's Name:\n",i+1);
            gets(s.f.da[i]);
        }
    }
    fflush(stdin);
    printf("Enter your Mob.no:\n");
    gets(s.mob);
    printf("Enter your Aadhar.no:\n");
    gets(s.aadhar);
    printf("Enter your Occupation:\n");
    gets(s.occu);
    printf("Enter your salary:\n");
    scanf("%d",&s.sal);
    

    
    printf("Name: %s\nFather's Name: %s\nMother's Name: %s\nDate of Birth=%d-%d-%d\nAge=%d\nMobile no: %s\nAadhar no: %s\nOccupation: %s\nSalary: %d",s.nm,s.f.fnm,s.f.mnm,s.dob.dd,s.dob.mm,s.dob.yyyy,age(s.dob.yyyy),s.mob,s.aadhar,s.occu,s.sal);
    if(s.mar=='y' || s.mar=='Y')
    {
        if(s.gen=='m' || s.gen=='M')
        printf("Wife's Name: %s\n ",s.f.wife);
        else if(s.gen=='f' || s.gen=='F')
        printf("Husband's Name: %s\n",s.f.hs);
        printf("Child: %d\tSon: %d\tDaughter: %d\n",s.f.son+s.f.dau,s.f.son,s.f.dau);
        for(int i=0;i<s.f.son;i++)
        printf("%d Son's Name: %s\n",i+1,s.f.so[i]);
        for(int i=0;i<s.f.dau;i++)
        printf("%d Daughter's Name: %s\n",i+1,s.f.da[i]);
    }
    
    
}