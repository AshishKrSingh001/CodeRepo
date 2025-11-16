/*
    typedef:
        It is a keyword which is used to define an alternete name of any datatype.

        Syntax:
            typedef <old datatype> <new name>;

        Example:
            typedef int integer;
            typedef float real;
*/

#include <stdio.h>

void main()
{

    typedef int integer;
    typedef float real;
    integer r=10;
    real ar,pr;
    ar=3.14*r*r;
    pr=2*3.14*r;
    printf("Area of a circle with radius 10: %.2f\nParameter of circle: %.2f",ar,pr);


}