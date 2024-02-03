/*
    enumeration:
        1. Enumeration is a sequence of integer constant only.
        2. It is created with the help of enum keyword.
        3. It is user defined datatype.
        4. It's size is two byte.
        5. The value of enumeration can't be modified after initialization.
        6. The default sequence of enumiration must be started with 0.

        Syntax:
            enum <enumeration name> = {constant1=value,constant2=value......conatantn=value};

        Example:
            enum color{red=10,blue=20,brown=15};
            enum color{red,green,blue};

*/


#include <stdio.h>

void main()
{
    enum colour{red,blue,green};
    printf("%s",color[1]);
}