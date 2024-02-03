/*
    WAP in C to create a structure as named Account to input account number,account holders name,andbalance using function.
    A customer can credit and debit amount multiple times according to requirements using seperate function after thatgenerate mini statement.
*/

#include <stdio.h>
#define dsize 5
#define csize 5

int d[dsize],c[csize];
struct Account
{
    char acc_no[20],acc_nm[20];
    float bal;
}a;
void debit()
{
    a.bal=0;
    printf("Enter last %d credit amount:\n",dsize);
    for(int i=0;i<dsize;i++)
    scanf("%d",&d[i]);
}
void credit()
{
    printf("Enter last %d debit amount:\n",csize);
    for(int i=0;i<dsize;i++)
    scanf("%d",&c[i]);
}
void get_mini()
{
    printf("Account Holder name: %s\nAccount number: %s\n",a.acc_no,a.acc_nm);
    printf("CREDIT:\n");
    for(int i=0;i<csize;i++)
    printf("%d\n",c[i]);  
    printf("DEBIT:\n");
    for(int i=0;i<dsize;i++)
    printf("%d\n",d[i]);
    int count;
    for(int i=0;i<csize;i++)
    count=count+c[i];
    for(int i=0;i<dsize;i++)
    count=count+d[i];
    a.bal=count;
    printf("balance: %d",count);
    


}

void main()
{
    printf("Enter account no and holdar's name:");
    scanf("%s%s",a.acc_no,a.acc_nm);
    debit();
    credit();
    get_mini();
}