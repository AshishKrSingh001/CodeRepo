#include <stdio.h>

void findSIzeOf1DArray();
void findAddressOfSpecificPosition();
int main()
{
    // findSIzeOf1DArray();
    findAddressOfSpecificPosition();
    return 0;
}
void findSIzeOf1DArray()
{
    int lowerBound, upperBound;
    printf("Enter Lower-Bound: ");
    scanf("%d",&lowerBound);
    printf("Enter Upper-Bound: ");
    scanf("%d",&upperBound);
    int size = upperBound - lowerBound + 1;
    printf("Size of Array is %d",size);
}
void findAddressOfSpecificPosition()
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
}