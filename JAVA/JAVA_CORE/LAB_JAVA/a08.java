// WAP in java to input any binary number after that convert into decimal number.
package LAB_JAVA;
import java.util.Scanner;
import java.util.InputMismatchException;
class Binary
{
    String str;
    Scanner sc = new Scanner(System.in);
    Binary()
    {
        System.out.println("Enter any binary number:");
        str = sc.nextLine();
    }
    void toDecimal()
    {
        int num=0,base=1,i;
        for(i=0;i<str.length();i++)
        {
            int n = Integer.parseInt(String.valueOf(str.charAt(i)));
            if(n==0 || n==1)
            {
                System.out.println(n);
                num = n*base+num;
                base = base*2;
            }
            else
            {
                System.out.println("Invalid Input");
            }
        }
        if(i==str.length())
        {
            System.out.println("Decimal number of "+str+" : "+num);
        }
    }

    public static void main(String[] args) 
    {
        try
        {
            Binary b = new Binary();
            b.toDecimal();
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
