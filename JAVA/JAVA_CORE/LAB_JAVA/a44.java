/*
 *  Create class Number with only one private instance variable as a double
    primitive type. To include the following methods (include respective
    constructors) isZero( ), isPositive(), isNegative( ), isOdd( ), isEven( ),
    isPrime(), isAmstrong() the above methods return boolean primitive type.
    getFactorial(), getSqrt(), getSqr(), sumDigits(), getReverse() the above
    methods return double primitive type. void listFactor(), void dispBinary().
 */
package LAB_JAVA;

import java.util.Scanner;

class NumberOperation
{
    NumberOperation()
    {
        System.out.println("Welcome to Number class");
    }
    boolean iszero(double num)
    {
        if(num==0)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    boolean isPositive(double num)
    {
        if(num>0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    boolean isNegative(double num)
    {
        if(num<0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    boolean isOdd(double num)
    {
        if(num%2!=0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    boolean isEven(double num)
    {
        if(!isOdd(num))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    boolean isPrime(double num)
    {
        byte flag=0;
        for(int i=2;i<num/2;i++)
        {
            if(num%i==0)
            {
                flag=1;
                break;
            }
        }
        if(flag==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    boolean isAmstrong(double num)
    {
        int count=countOfDigit(num);
        double arm=0,n=num;
        while(num>0)
        {
            int d=(int)num%10;
            arm=arm+Math.pow(d,count);
            num=num/10;
        }
        if(n==arm)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    double getFactorial(double num)
    {
        double fact=0;
        for(int i=1;i<=(int)num;i++)
        {
            fact=fact+i;
        }
        return fact;
    }
    double getSqrt(double num)
    {
        return Math.sqrt(num);
    }
    double getSqr(double num)
    {
        return Math.pow(num, 2);
    }
    double sumDigits(double num)
    {
        int sum=0;
        while(num>0)
        {
            int d=(int)num%10;
            sum=sum+d;
            num=num/10;
        }
        return sum;
    }
    double getReverse(double num)
    {
        double rev=0;
        do
        {
            int d=(int)num%10;
            rev=rev*10+d;
            num=(long)num/10;
        }while(num>0);
        return rev;
    }
    int countOfDigit(double num)
    {
        int count=0;
        do
        {
            count++;
            num=(long)num/10;
        }while(num>0);
        return count;
    }
    void listFactor(double num)
    {
        System.out.print("Factors of "+num+" is: ");
        for(int i=1;i<=(int)num;i++)
        {
            if(num%i==0)
            {
                System.out.print(i+"\t");
            }
        }
        System.out.println(" ");
    }
    void dispBinary(double num)
    {
       StringBuffer str = new StringBuffer();
       int i=0;
       while(num>0)
       {
            int d=(int)num%2;
            str.insert(i,d);
            i++;
            num=(long)num/2;
       }
       System.out.println("Binary: "+str.reverse());
    }

    
}
public class a44 
{
    public static void main(String[] args) 
    {
        double num=1024;
        System.out.println("Enter a number: ");
        Scanner sc = new Scanner(System.in);
        num=sc.nextDouble();
        NumberOperation n = new NumberOperation();
        System.out.println("Is "+num+" Zero: "+n.iszero(num));
        System.out.println("Is "+num+" Positive: "+n.isPositive(num));
        System.out.println("Is "+num+" Negative: "+n.isNegative(num));
        System.out.println("Is "+num+" Prime: "+n.isPrime(num));
        System.out.println("Is "+num+" Armstrong: "+n.isAmstrong(num));
        System.out.println("Is "+num+" Evan: "+n.isEven(num));
        System.out.println("Is "+num+" Odd: "+n.isOdd(num));
        System.out.println("Count of digit of "+num+" is: "+n.countOfDigit(num));
        System.out.println("Factorial of "+num+" is: "+n.getFactorial(num));
        System.out.println("Square root of "+num+" is: "+n.getSqrt(num));
        System.out.println("Square of "+num+" is: "+n.getSqr(num));
        System.out.println("Reverse of digit of "+num+" is: "+n.getReverse(num));
        System.out.println("Sum of digit of "+num+" is: "+n.sumDigits(num));
        n.listFactor(num);
        n.dispBinary(num);

    }    
}
