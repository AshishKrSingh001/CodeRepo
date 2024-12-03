// Online C compiler to run C program online
#include <stdio.h>
#include <string.h>
int main() {
    char str[100];
    scanf("%s",str);
    int n = strlen(str);
    for(int i=0;i<n/2;i++){
        if(str[i] != str[n-i-1]){
            printf("Not Palindrome");
            return 0;
        }
    }
    printf("Palindrome");

    return 0;
}