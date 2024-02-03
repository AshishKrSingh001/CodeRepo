// Write a program using vector class. 
package LAB_JAVA;

import java.util.Scanner;
import java.util.Vector;

public class a46 
{
    public static void main(String[] args) 
    {
        System.out.println("Enter 5 name: ");   
        Vector v = new Vector<>();
        Scanner sc = new Scanner(System.in);
        String str;
        for(int i=0;i<5;i++)
        {
            str=sc.nextLine();
            v.add(str);
        } 
        System.out.println("Entered name is: ");
        for(Object element:v)
        {
            System.out.println(element);
        }
    }    
}
