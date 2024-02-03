/*
 * WAP in java to create a thread to printing each character of your name during 1sec interval time;
 */
import java.io.*;
class Myname implements Runnable
{
    String name;
    DataInputStream ds = new DataInputStream(System.in);
    Myname()    throws IOException
    {
        System.out.println("Enter your name: ");
        name = ds.readLine();
    }
    public void run()
    {
        try
        {
            for(int i=0;i<name.length();i++)
            {
                System.out.println(name.charAt(i));
                Thread.sleep(1000);
            }
        }
        catch(InterruptedException e)
        {}
        catch(StringIndexOutOfBoundsException e)
        {
            System.out.println("Invalid Index "+e);
        }
    }
    public static void main(String[] args) throws IOException
    {
       Myname obj = new Myname();
       Thread t = new Thread(obj);
       t.start(); 
    }
}

