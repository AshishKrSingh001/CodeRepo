// WAP in java to input any string after that print in reverse order
package LAB_JAVA;

import java.util.Scanner;

public class a26 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a string: ");
        String str = sc.nextLine();
        System.out.println("String: "+str);
        StringBuffer s = new StringBuffer(str);
        s.reverse();
        String st = new String(s);
        System.out.println("Reverse String: "+st);
    }    
}
