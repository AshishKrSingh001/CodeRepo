#include <stdio.h>

void main()
{
    FILE *f;
    int n,sum1=0,sum2=0,sum=0,i=0;
    f=fopen("file.dat","w");
     while(i!=10)
    {
        scanf("%d",&n);
        fprintf(f,"%d\n",n);
        i++;
    }
    fclose(f);
    
    f=fopen("file.dat","r");
    for(i=0;fscanf(f,"%d",&n)!=EOF;i++)
    {
        sum=sum+n;
        if(i%2!=0)
        sum1=sum1+n;
        else
        sum2=sum2+n;
    }
    printf("Addition: %d\nOdd Element Addition: %d\nEven Element Addition: %d",sum,sum1,sum2);
    fclose(f);
}