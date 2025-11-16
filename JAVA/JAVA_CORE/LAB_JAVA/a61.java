/*
 * Write a program to get the reference to the current thread by calling
    currentThread() method. 
 */
package LAB_JAVA;

import java.util.Scanner;

class C_Thread extends Thread
{
   int arr[],n;
   Scanner sc = new Scanner(System.in);
   C_Thread()
   {
      System.out.println("Enter size of array: ");
      n = sc.nextInt();
      arr = new int[n];

      System.out.println("Enter "+n+" Array element: ");
      for(int i=0;i<n;i++)
      {
         arr[i]=sc.nextInt();
      }
   }
   
   public void run()
   {
      System.out.println("Array element: ");
      for(int element: arr)
      {
         System.out.print(element+"\t");
         try
         {
            Thread.sleep(2000);
         }
         catch(InterruptedException e)
         {}
      }
      System.out.println(" ");
      
   }

   
}
public class a61 
{
   public static void currentThread(C_Thread obj)
   {
      obj.start();
   }   
   public static void main(String[] args) 
   {
      C_Thread obj = new C_Thread();
      currentThread(obj);   
   } 
}
