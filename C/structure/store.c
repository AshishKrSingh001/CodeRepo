#include <stdio.h>

struct customer
{
    int quan[10],pp[10];
    char nm[20],no[10],p_nm[10][20];
    float gst[10],dis[10],t_amt,amt[10],p[10];
};

void main()
{
    int i,c;
    char ch;
    struct customer com;
    printf("\nEnter Customer's name: ");
    gets(com.nm);
    printf("Enter Phone No: ");
    gets(com.no);
    printf("How many Items are there?");
    scanf("%d",&c);
    for(i=0;i<c;i++)
    {
        printf("Enter %d product Name: ",i+1);
        scanf("%s",com.p_nm[i]);
        // gets(com.p_nm[i]);
        printf("Enter %d product Quantity: ",i+1);
        scanf("%d",&com.quan[i]);
        printf("Enter %d product price: ",i+1);
        scanf("%d",&com.pp[i]);
    }

    
    for(i=0;i<c;i++)
    {

        com.p[i]=com.pp[i]*com.quan[i];
        com.dis[i]=com.p[i]/10;
        com.gst[i]=(com.p[i]*9)/100;
        com.amt[i]=(com.p[i]-com.dis[i])+2*(com.gst[i]);

    }

    puts("*************************************************************************************************************************************");

    puts("\n\n\t\t\t\t\t\t\t\tGST INVOICE");
    puts("\t\t\t\t\t\t\tBACHAT BAAZAR SUPER MARKET");
    puts("\t\t\t\t\t\t     (Unite:- Rose Merry Enterprises)");
    puts("\t\t\t\t\t\t Signature tower Appartment, Kurji pul Patna");
    puts("\t\t\t\t\t\t\tPhone: 9709347679 / 8676901318");
    puts("\t\t\t\t\t\t\t    GST No: 10AA7PL2375E1ZO\n");
    puts("*************************************************************************************************************************************");
    printf("\nCustomer: %s\t\t\t\t\t\t\t\t\t\t\t\t\tBill no: A000021\nMobile: %s\t\t\t\t\t\t\t\t\t\t\t\t\tDate: 04-02-2023\nPayment: Cash\t\t\t\t\t\t\t\t\t\t\t\t\tTime: 13:03\n\n\n",com.nm,com.no);
    

    puts("SI\tProduct\t\tQty\t\tRate\t\tDis\t\tPrice\t\tSGST\t\tCGST\t\tAmount");
    com.t_amt=0;
    for(i=0;i<c;i++)
    {
        printf("%d\t%s\t\t%d\t\t%d\t\t%.2f\t\t%.2f\t\t%.2f\t\t%.2f\t\t%.2f\n",i+1,com.p_nm[i],com.quan[i],com.pp[i],com.dis[i],com.p[i],com.gst[i],com.gst[i],com.amt[i]);
        com.t_amt=com.t_amt+com.amt[i];
    }
    printf("\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tTotal Amount: %.2f\n",com.t_amt);

    puts("************************************************************************************************************************************");


}