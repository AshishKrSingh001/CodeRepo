#include <stdio.h>
int main(){
    FILE *fp;
    fp = fopen("formattedData.dat", "w");
    if(fp == NULL){
        printf("File not found");
        return 0;
    }
    char name[10];
    int id;
    int rollNo;
    fscanf(fp, "%s%d%d", name, id, rollNo);
    fclose(fp);
    printf("Name: %s\nId: %d\nRoll No: %d", name, id, rollNo);
    return 0;
}