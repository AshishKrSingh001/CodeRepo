// WAP in java to input any string after that print greatest character.
package LAB_JAVA;
import java.util.Scanner;
public class a27 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a string: ");
        String str = sc.nextLine();
        System.out.println("String: "+str);
        char ch=str.charAt(0);
        for(int i=1;i<str.length();i++)
        {
            if(str.charAt(i)>ch)
            {
                ch = str.charAt(i);
            }
        }
        System.out.println("Greatest char: "+ch);

    }    
}
