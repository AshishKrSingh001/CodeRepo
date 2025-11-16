// WAP in java to input 10 numbers after that find greatest and smallest number.
package LAB_JAVA;
import java.util.Scanner;

import javax.swing.text.html.parser.Element;
class Array_1D
{
    int a[];
    int n;
    Scanner s=new Scanner(System.in);
    Array_1D()
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
    void max_min()
    {
        int gt= a[0],st=a[0];
        for(int element:a)
        {
            if(gt < element)
            {
                gt=element;
            }
            if(st > element)
            {
                st=element;
            }
        }
        System.out.println("greatest number: "+gt+"\nsmallest number: "+st);

    }
    public static void main(String[]args)
    {
        Array_1D o=new Array_1D();
        o.input();
        o.output();
        o.max_min();
    }
}    

