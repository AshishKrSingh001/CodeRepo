// Write a program to accept specified number of characters as input and converts them into uppercase characters.

package LAB_JAVA;

import java.util.Scanner;

public class a57 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        char ch[] = new char[10];
        System.out.println("Enter 5 character: ");
        for(int i=0;i<5;i++)
        {
            ch[i]=sc.next().charAt(0);
        }
        for(int element:ch)
        {
            int a=(int)element;
            if((int)element>=97 && (int)element<=122)
            {
                a=(int)element-32;
            }
            System.out.println((char)a);
        }    
    }    
}
