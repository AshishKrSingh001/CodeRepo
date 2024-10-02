#include <stdio.h>

int main()
{
    int baseAdd, w, position, add;
    printf("Enter Base Address: ");
    scanf("%d",&baseAdd);
    printf("Enter Position: ");
    scanf("%d",&position);
    printf("Enter weight of word: ");
    scanf("%d",&w);
    add = baseAdd + (position-0)*w;
    printf("Address of the ith element is %d",add);
    return 0;
}