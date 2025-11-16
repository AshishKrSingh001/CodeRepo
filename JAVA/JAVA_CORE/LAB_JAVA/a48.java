// Write a program for example of multiple catch statements occurring in a program. 

package LAB_JAVA;

import java.util.Scanner;

public class a48 
{
   private int arr[],n;
   Scanner sc = new Scanner(System.in);
   a48()
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
         a48 a = new a48();
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

