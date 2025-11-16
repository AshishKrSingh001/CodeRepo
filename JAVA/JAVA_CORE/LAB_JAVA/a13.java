//3WAP in java to input any decimal number after that convert into binary number.
package LAB_JAVA;

import java.util.ArrayList;
import java.util.Scanner;

class Binary_
{
    int num;
    StringBuffer str = new StringBuffer();
    int count=0;
    Scanner s= new Scanner(System.in);
    
    Binary_()
    {
        System.out.println("Enter a decimal number: ");
        num=s.nextInt();

    }
    StringBuffer binary()
    {
        for(int i=0;num>0;i++)
        {
            int d=num%2;
            str.insert(i, d);
            num=num/2;
        }
        return str.reverse();
        
    }
    
    public static void main(String[] args) 
    {
        Binary_ bin = new Binary_();
        System.out.println("Binary number: "+bin.binary());
    }
}

