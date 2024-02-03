// WAP in java to input 10 numbers after that sort data in ascending order

package LAB_JAVA;
import java.util.Scanner;

import javax.swing.text.html.parser.Element;
class Array_
{
    int a[];
    int n;
    Scanner s=new Scanner(System.in);
    Array_()
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
    void sorting()
    {
        for (int i=0;i<=n-2;i++) 
        {
             for(int j=i+1;j<n;j++)
             {
                if(a[i]>a[j])
                {
                    int temp=a[i];
                    a[i]=a[j];
                    a[j]=temp;
                }                
             }
        }
        
    }     

    
    public static void main(String[]args)
    {
        Array_ o=new Array_();
        o.input();
        o.output();
        o.sorting();
        o.output();

       
    }
}    

