/*
 * Write a program to give the example of control statements.
        a. If statements.
        b. Switch Statements.
        c. For loop.
        d. While Statements.
        e. Do statements
 */
package LAB_JAVA;

import java.util.InputMismatchException;
import java.util.Scanner;

class Number
{
    int num;
    Scanner sc = new Scanner(System.in);
    Number()
    {
        System.out.println("Enter a number: ");
        num = sc.nextInt();
        
    }
    void check_prime()
    {
        byte flag = 0;
        for(int i=2;i<=num/2;i++)
        {
            if(num%i==0)
            {
                flag = 1;
            }
        }
        if(flag==0 && num!=1 && num!=0)
        {
            System.out.println("It is a prime number");
        }
        else
        {
            System.out.println("It is not a prime number");
        }
    }
    int reverse(int num)
    {
        int n = num,rev = 0;
        while(n>0)
        {
            int d=n%10;
            rev=rev*10+d;
            n=n/10; 
        }
        return rev;
    }
    void reverse_of_digit()
    {
        System.out.println("Reverse of "+num+" : "+reverse(num));
    }
    void check_palindrome()
    {
        if(reverse(num)==num)
        {
            System.out.println("It is palindrome");
        }
        else
        {
            System.out.println("It is not palindrome");
        }
    }
    void sum_of_digit()
    {
        int n = num,sum = 0;
        while(n>0)
        {
            int d=n%10;
            sum=sum*10+d;
            n=n/10; 
        }
        System.out.println("Sum of digit: "+sum);
    }
    void count_of_digit()
    {
        int n = num,count=0;
        do
        {
            int d=n%10;
            count=count*10+d;
            n=n/10;
        }while(n>0);
        System.out.println("Sum of digit: "+count);
    }
    void Select()
    {
        System.out.println("\nEnter\n1.Check prime\n2.Check palindrome\n3.Count of digit\n4.Sum of digit\n5.Reverse of digit\n\nEnter choice: ");
        int choice = sc.nextInt();
        switch(choice)
        {
            case 1:
            check_prime();
            break;
            case 2:
            check_palindrome();
            break;
            case 3:
            count_of_digit();
            break;
            case 4:
            sum_of_digit();
            break;
            case 5:
            reverse_of_digit();
            break;

        }
    }
    public static void main(String[] args) 
    {
        
        try
        {
            Number num = new Number();
            num.Select();
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
