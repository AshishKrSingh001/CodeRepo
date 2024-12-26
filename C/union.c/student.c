#include <stdio.h>

typedef union student{
    int id;
    char name[50];
    float fees;
}stud;
int main(){
    // typedef struct student stud;
    stud s1, s2;
    gets(s1.name);
    s1.id = 101;
    s1.fees = 16000;
    gets(s2.name);
    s2.id = 105;
    s2.fees = 17000;
    
    printf("\n%s\n%d\n%f\n", s1.name, s1.id, s1.fees);
    printf("\n%s\n%d\n%f", s2.name, s2.id, s2.fees);
    
    return 0;
}