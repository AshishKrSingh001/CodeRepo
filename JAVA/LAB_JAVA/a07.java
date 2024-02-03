// WAP in java to print series of strong number upto 1000.
package LAB_JAVA;
import java.util.Scanner;
import java.util.InputMismatchException;
class Strong
{
    int num;
    Strong()
    {
        System.out.println("Enter a number:");
        Scanner sc = new Scanner(System.in);
        num = sc.nextInt();
        
    }
    void Display()
    {
        int n=num;
        long fact=0,f;
        while(num>0)
        {
            int d = num%10;
            f=1;
            for(int i=1;i<=d;i++)
            {
                f=f*i;
            }
            fact = fact+f;
            num = num/10;
        }
        if(n==fact)
        {
            System.out.println("Strong");
        }
        else
        {
            System.out.println("Not Strong");
        }
    }
    public static void main(String[] args) 
    {
        try
        {
            Strong P = new Strong();
            P.Display();
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

