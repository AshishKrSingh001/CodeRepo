#include <stdio.h>
struct Integer
{
    int n,sum;
};
void main()
{
    FILE *f;
    struct Integer i;
    i.sum=0;
    int size,j;

    // f=fopen("data.bin","wb");
    // printf("How many integer you want to add:");
    // scanf("%d",&size);
    // printf("Enter integer number:\n");
    // for(j=0;j<size;j++)
    // {
    //     scanf("%d",&i.n);
    //     fwrite(&i,sizeof(i),1,f);
    // }
    // fclose(f);

    f=fopen("data.bin","rb");
    if(f==NULL)
    printf("File not found");
    else
    {
        while(fread(&i,sizeof(i),1,f)==1)
        {
            printf("%d\t",i.n);
            i.sum=i.sum+i.n;
        }
        printf("\nSum of all integer: %d",i.sum);
    }
    fclose(f);
}