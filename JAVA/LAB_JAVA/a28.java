// WAP in java to input five strings after that print it.
package LAB_JAVA;
import java.util.Scanner;
public class a28 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter five string: ");
        String []str=new String[5];
        for(int i=0;i<5;i++)
        {
            str[i]=sc.nextLine();
        }
        for(int i=0;i<5;i++)
        {
            System.out.println("String"+(i+1)+": "+str[i]);
        }
    }    
}
