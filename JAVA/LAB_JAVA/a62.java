/*
 * Write a program to create two threads. In this class we have one constructor
    used to start the thread and run it. Check whether these two threads are run
    are not. 
 */
package LAB_JAVA;
class Thread__1 extends Thread
{
   public void run()
   {
      for(int i=0;i<10;i++)
      {
         System.out.println("Good Morning");
         try
         {
            Thread.sleep(1000);
         }
         catch(InterruptedException e)
         {}
      }
   }
}
class Thread__2 extends Thread
{
   public void run()
   {
      for(int i=0;i<10;i++)
      {
         System.out.println("Hello");
         try
         {
            Thread.sleep(1000);
         }
         catch(InterruptedException e)
         {}
      }
   }
}
public class a62 
{
   a62()
   {
      Thread__1 t1 = new Thread__1();
      Thread__2 t2 = new Thread__2();
      t1.start();
      t2.start();
   }    
   public static void main(String[] args) 
   {
      a62 a = new a62();
   }
}
