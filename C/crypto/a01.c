#include <stdio.h>
#include <string.h>


void encryptSuperposition(char cipherText[], char key[]){
    for(int i=0;i<strlen(cipherText);i++){
        int keyValue = key[i%strlen(key)];
        printf("\n%d - ", cipherText[i]);
        if('A' <= cipherText[i] && cipherText[i] <= 'Z' && 'A' <= keyValue && keyValue <= 'Z'){
            cipherText[i] = 65 + (((cipherText[i] - 64)+ (keyValue - 64)) % 27);
        }printf("%d", cipherText[i]);
        // else if('a' <= message[i] && message[i] <= 'z' && 'a' <= key[i] && key[i] <= 'z'){
        //     message[i] = 96 + ((message[i] - 96)+ (keyValue - 96) % 26);
        // }
        // else{
        //     puts("Please enter valid message or key");
        //     break;
        // }
    }
}
void decryptSuperposition(char message[], char key[]){
    for(int i=0;i<strlen(message);i++){
        int keyValue = key[i%strlen(key)];
        // printf("\n%d", keyValue);
        if('A' <= message[i] && message[i] <= 'Z' && 'A' <= keyValue && keyValue <= 'Z'){
            message[i] = 65 + (((message[i] - 64)- (keyValue - 64)) % 27);
        }
    }
}

int main()
{
    //char message[50]="ZZZ", key[10]="A";
    char message[50], key[10];
    puts("Enter message to encrypt: ");
    gets(message);
    puts("Enter Key: ");
    gets(key);
    encryptSuperposition(message, key);
    puts(message);
    decryptSuperposition(message, key);
    puts(message);
}