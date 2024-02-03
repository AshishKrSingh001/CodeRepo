/*
    Preprocessor directive:
        1. It is executed automatically before sourcecode.S it is called preprocessor.
        2. All preprocessor directive must be stsrted with # symbol.
        3. It must be written as first line ststement in source code.
        4. It is not terminated with semicolon.

        Example:
            #include,#define,#if,#else,#error,#line,etc

        Types of preprocessor directive:
            There are three types of preprocessor directive:
                1. File inclusion directive:
                    In this directive we include header filr in source code with the help of #include.

                    Syntax:
                        #include <header file>
                        or
                        #include "header file"

                    Example:
                        #include <stdio.h>
                        or
                        #include "math.h"

                2. Macro subtitution directive
                    In this directive we define macro in program.
                    In C programming macro can be used as symbolic constant and function, it is implemented with the help of #difine prepreocessor directive.

                    Syntax:
                        #difine <macro constant name> <value>

                    Example:
                        #define size 10
                        #define PI 3.14
                        #define max 100
                        #define expr 10+20*5

                    Macro function:
                        It is a type of simplified function because it consists of very less coding. 
                        It is implemented with the help of #define preprocessor directive.
                        This Function doesn't contain if and looping statement.
                        It's execution is faster then normal function.

                        Syntax:
                            #define <macro function name>(parameter list)

                        Example:
                            #include <stdio.h>
                            #define sqr(n) n*n
                            #define cube n*n*n

                3. conditional directive:



*/

#include <stdio.h>
#define pi 3.14
#define ar 5-2
#define size 10
#define s 10+2
#define sqr(n) n*n
#define great(a,b,c) (a>b && a>c)?a:(b>c)?b:c

void main()
{
    printf("s=%d\npi=%f\nar=%d\n",s,pi,ar);
    printf("%d",sqr(50));
    printf("\n%d",great(10,11,21));

}