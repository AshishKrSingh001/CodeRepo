#include <stdio.h>

int main(){
    FILE *f;
    char ch;
    f = fopen("test.c", "r");
    if(f==NULL){
        printf("File Not Found");
        return 0;
    }else{
        while(ch=getc(f)!=EOF){
            printf("%c",ch);
        }
    }
    f=fclose(f);
}