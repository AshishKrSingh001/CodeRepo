// Array:
// An array is the collection of data items of the same page.
//  Items are stored at contiguous memory locations.
//  It can also store the collection of derived data types,such as pointers,structure,etc.
//  A one-dimensional array is like a list.
//  A two dimensional array is like a table.
#include <stdio.h>
int main(){
    int marks[]={1,2,3,4,5,6,7,8,9},i;
    // marks[0]=101;
    // printf("marks of student 1 is %d\n",marks[0]);
    // marks[1]=102;
    // printf("marks of student 2 is %d\n",marks[1]);
    // marks[2]=103;
    // printf("marks of student 3 is %d\n",marks[2]);
    // marks[3]=104;
    // printf("marks of student 4 is %d\n",marks[3]);
    // for(i=0;i<=3;i++){
    //     printf("marks of student is:");
    //     scanf("%d",&marks[i]);
    // }

    printf("marks of student\n");
    for(i=0;i<9;i++){
        
        printf("%d\t",marks[i]);
    }
    return 0;
}