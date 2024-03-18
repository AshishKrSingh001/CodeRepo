
import java.util.Scanner;
public class a43_for_loop
{
    public static void main(String[] args)
    {
        System.out.println("Enter a number:");
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        int i;
        double fact=1;
        for(i=num;i>=1;i--)
        {
            fact = fact * i;
        }
        System.out.println("Factorial of given digit is "+ fact);
    }
}
