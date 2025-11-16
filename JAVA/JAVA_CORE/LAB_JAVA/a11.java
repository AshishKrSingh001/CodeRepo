//WAP in java to input 10 numbers after that search any particular value.
package LAB_JAVA;
import java.util.Scanner;

import javax.swing.text.html.parser.Element;
class Array_1
{
    int a[];
    int n;
    Scanner s=new Scanner(System.in);
    Array_1()
    {
        System.out.println("Enter size of array ");
        
        n=s.nextInt();
        a=new int[n];
        
    }
    void input()

    {
        System.out.println("Enter "+n+" number :");
        for(int i=0;i<n;i++)
        {
            a[i]=s.nextInt();
        }
    }
    void output()

    {
        System.out.println("Array :");
        for(int element:a)
        {
            System.out.print(element+"\t");            
        }
        System.out.println(" ");
    }
    void searching()
    {
        int sc,i;
        System.out.println("Enter number you want to search: ");
        sc=s.nextInt();
        for (i=0;i<n;i++) 
        {
            if(sc==a[i])
            {
                System.out.println("found ");
                break;
            }            
        }
        if(i==n)
        {
            System.out.println("not found");
        }

    }
 
        

    
    public static void main(String[]args)
    {
        Array_1 o=new Array_1();
        o.input();
        o.output();
        o.searching();

       
    }
}    

