// .WAP in java to input any character after that check character is vowel or consonant. 
package LAB_JAVA;

import java.util.Scanner;

public class a25 
{
    public static void main(String[] args) 
    {
        System.out.println("Enter a character: ");
        Scanner sc = new Scanner(System.in);
        char ch =  sc.next().charAt(0);
        switch(ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
            System.out.println("Vowel");
            break;
            default:
            System.out.println("consonant");
        }    
    }
}
