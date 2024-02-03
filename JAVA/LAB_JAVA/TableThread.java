/*
 * WAP in java to create a thread for printing table of any numberduring 1s interval time using thread class;
 */

import java.util.*;
public class TableThread extends Thread
{
    int n;
    Scanner sc = new Scanner(System.in);
    TableThread()
    {
        System.out.println("Enter any number: ");
        n = sc.nextInt();
    }
    public void run()
    {
        try
        {
            for(int i=1;i<=10;i++)
            {
                System.out.printf("%d X %d: %d\n",n,i,n*i);
                Thread.sleep(1000);
            }
        }
        catch(InterruptedException e)
        {}
        

    }
    public static void main(String[] args) 
    {
        TableThread t = new TableThread();
        t.start();
    }
}

