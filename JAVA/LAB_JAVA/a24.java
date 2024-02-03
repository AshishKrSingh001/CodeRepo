// WAP in java to input any string after that find length.
package LAB_JAVA;
import java.util.Scanner;

class string
{
    String str;
    Scanner sc = new Scanner(System.in);
    string()
    {
        System.out.println("Enter a string: ");
        str = sc.nextLine();
        System.out.println("String is: "+str+"\nLength of String: "+str.length());
    }
    public static void main(String[] args) 
    {
        string s = new string();
    }
}