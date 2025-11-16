#include <stdio.h>
#include <conio.h>
#include <string.h>

int main(){
    FILE *fp;
    fp = fopen("writeInTextFile", "w");
    char ch;
    printf("Enter content to write in file: (for terminate press #)\n");
    while((ch = getchar()) != '#'){
        putc(ch, fp);
    }
    fclose(fp);
    return 0;
}