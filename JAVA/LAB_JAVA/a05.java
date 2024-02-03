/*
 * WAP in java to input any number after that print only prime digit
 */
package LAB_JAVA;
import java.util.Scanner;
import java.util.InputMismatchException;


import java.util.Scanner;

class Prime
{
    int num;
    Prime()
    {
        System.out.println("Enter a number:");
        Scanner sc = new Scanner(System.in);
        num = sc.nextInt();
        
    }
    void Display()
    {
        while(num>0)
        {
            int d = num%10;
            byte flag = 0;
            for(int i=2;i<=d/2;i++)
            {
                if(d%i==0)
                {
                    flag = 1;
                }
            }
            if(flag==0 && d!=1 && d!=0)
            {
                System.out.println(d);
            }
            num = num/10;
        }
    }
    public static void main(String[] args) 
    {
        try
        {
            Prime P = new Prime();
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
