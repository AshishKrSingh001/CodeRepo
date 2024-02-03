#include <stdio.h>
#define expr(x) (3*x)+1
#define x(x,y) (x+(expr(x)*(y-x)))/(expr(x)+expr(y))

void main()
{
    float a,b,c;
    for(int i=0;i<5;i++)
    {
        if(expr(i)*expr(i+1)<0)
        {
            a=i;
            b=i+1;
            break;
        }
    }
    for(int i=0;i<3;i++)
    {
        c=x(a,b);
        if((expr(c)*expr(a))<0)
        {
            b=c;
        }
        else
        a=c;
    }
    printf("%d",x(a,b));

}