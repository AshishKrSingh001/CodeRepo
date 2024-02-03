// Write a program to illustrate usage of try/catch with finally clause. 
/*
 * Write a program for example of try and catch block. In this check
    whether the given array size is negative or not. 
 */
package LAB_JAVA;

import java.util.Scanner;

public class a49 
{
   private int arr[],n;
   Scanner sc = new Scanner(System.in);
   a49()
   {
      System.out.println("Enter size of array: ");
      n=sc.nextInt();
      arr=new int[n];
   }
   void input()
   {
      System.out.println("Enter element of array:");
      for(int i=0;i<n;i++)
      {
         arr[i]=sc.nextInt();
      }
   }
   void output()
   {
      System.out.println("Element of array:");
      for(int i:arr)
      {
         System.out.print(i+"\t");
      }
      System.out.println(" ");
   }
   public static void main(String[] args) 
   {
      try
      {
         a49 a = new a49();
         a.input();
         a.output();
      }
      catch(NegativeArraySizeException e)
      {
         System.out.println("Negative size given: "+e);
      }
      catch(ArrayIndexOutOfBoundsException e)
      {
         System.out.println("Invalid index: "+e);
      }
      catch(NumberFormatException e)
      {
         System.out.println("Invalid input: "+e);
      }
      catch(NullPointerException e)
      {
         System.out.println(e);
      }
      finally
      {
         System.out.println("Thanks");
      }
   }

}

