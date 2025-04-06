#include <stdio.h>

int main(){
    FILE *fp;
    fp = fopen("readInTextFileExample.c", "r");
    if(fp == NULL){
        printf("File not found");
        return 0;
    }
    char ch;
    int noOfLines = 0;
    int noOfWords = 0;
    int noOfChars = 0;
    while((ch = fgetc(fp)) != EOF){
        noOfChars++;
        if(ch == '\n'){
            noOfLines++;
        }else if(ch == ' '){
            noOfWords++;
        }
        printf("%c", ch);
    }
    fclose(fp);
    printf("\n\nNo of Lines: %d\nNo of Words: %d\nNo of Characters: %d\n", noOfLines, noOfWords, noOfChars);
    return 0;
}