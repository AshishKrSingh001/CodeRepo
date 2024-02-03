// WAP in java to input three number after that find root of quadratic equation.
package LAB_JAVA;
import java.util.Scanner;
import java.util.InputMismatchException;
public class a06 
{
    public static void main(String[] args) 
    {
        try
        {
            Scanner sc = new Scanner(System.in);
            System.out.println("Enter three coefficient(respectively)");
            double a = sc.nextInt();
            double b = sc.nextInt();
            double c = sc.nextInt();
            double root1 = (-b+Math.sqrt(Math.pow(b, 2)-(4*a*c)))/(2*a);
            double root2 = (-b-Math.sqrt(Math.pow(b, 2)-(4*a*c)))/(2*a);
            System.out.println("First root: "+root1+"\nSecond root: "+root2);
        }
        catch(NumberFormatException e)
        {
            System.out.println("Invalid Input: "+e);
        }
        catch(InputMismatchException e)
        {
            System.out.println("Invalid Input: "+e);
        }    
    }
}
