/*
    File:
        File is a type of storage which is used to store record permanently.

        Types of file:
            1. Sequential file
                Types of Sequential file:
                    a. Text file
                        Extention: .txt

                    b. Data file
                        Extention: .dat
            2. Random file/Binary file
                Extention: .bin
        Operation on file:
            1. Read
            2. Write
            3. Append
        File mode:
            mode    meaning
            w       Write
            r       Read
            a       Append
            w+      Write + Read
            r+      Read + write
            a+      Append + Read
            wb      write in binary file   
            rb      Read in binary file
            wb+     Write + Read in binary file 
            rb+     Read + write in binary file 
            ab+     Append + Read in binary file 

        Steps of file operation:

            Step 1.
                We declare file pointer file mode
                i.e File *<file pointer>;
                e.g File *fp;

            Step 2.
                We open a file with the help of  a function i.e fopen().
                fopen():
                    This function is used to open a new and existing file
                    Syntax:
                        <file pointer> = fopen("File_name","File_mode")
                    e.g:
                        fp = fopen("mytext.txt","w");
            Step 3.
                We perform operation on file according to requirement.
                For this we use several input and output function.
                Function:
                    getc();
                    putc();
                    fgetc();
                    fputc();
                    fprintf();
                    fscanf();
                    fread();
                    fwrite();

            Step 4.
                We close a file with the help of fclose() function.
                Syntax:
                    void fclose(file_pointer);
                    e.g:
                        fclose(fp);


*/
/*
    1. getc():This function is used to read one character from a file.
        syntax:
            char getc(file pointer);

        example:
            char ch;
            ch=getc(fp);

    2. putc():This fuction is used to write one character in a file.
        syntax:
            void putc(char.value,file pointer);

        example: 

        These function is unformated input operation(Doesn't use format specifier)
        getch():Not visible in console and doesn't require to press enter key
        getche():Visble in console and doesn't require to press enter key
        getchar():Visble in console and require to press enter key
*/

// WAP in C to write information about your self in a file.
#include <stdio.h>
void main()
{
    FILE *fp;
    char ch;
    fp=fopen("my_info.txt","w");
    printf("\nEnter information about yourself:\n");

    while((ch=getchar())!=EOF)
    {
        putc(ch,fp);
    }
    fclose(fp);

}