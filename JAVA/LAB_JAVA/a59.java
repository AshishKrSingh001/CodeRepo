/*
 * Write a java program that creates three threads. First thread displays “Good
    Morning” every one second, the second thread displays “Hello” every two
    seconds and the third thread displays “Welcome” every three seconds. 
 */
package LAB_JAVA;
class Thread_1 extends Thread
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
class Thread_2 extends Thread
{
   public void run()
   {
      for(int i=0;i<10;i++)
      {
         System.out.println("Hello");
         try
         {
            Thread.sleep(2000);
         }
         catch(InterruptedException e)
         {}
      }
   }
}
class Thread_3 implements Runnable
{
   public void run()
   {
      for(int i=0;i<10;i++)
      {
         System.out.println("Welcome");
         try
         {
            Thread.sleep(3000);
         }
         catch(InterruptedException e)
         {}
      }
   }
}
public class a59 
{
   public static void main(String[] args) 
   {
      Thread_1 t1 = new Thread_1();
      //t1.start();
      t1.run();
      Thread_2 t2 = new Thread_2();  
      //t2.start();
      t2.run();
      Thread_3 t3 = new Thread_3();     
      Thread t = new Thread(t3);
      //t.start();
      t.run();
      
   }    
}
