#include <stdio.h>
typedef struct Student{
    char name[20];
    int id;
    float fees;
};
int main(){
    FILE *fp;
    fp = fopen("formattedData.dat", "w");
    Student student1 = {"Ashish Kumar Singh", 101, 16000.00};
    fwrite(&student1, sizeof(student1), 1, fp);
    fclose(fp);
    return 0;
}