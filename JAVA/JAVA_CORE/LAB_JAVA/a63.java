/*
 * Create a multithreaded program by creating a subclass of Thread and then
    creating, initializing, and staring two Thread objects from your class. The
    threads will execute concurrently and display Java is hot, aromatic, and
    invigorating to the console window. 
 */
package LAB_JAVA;
/*
 * Implementing Synchronization
 * 1)this & super keyword
 * 2)this() & super() method
 * 11-05-2023
 */
class WishingMsg 
{
    synchronized void wish(String name)
    //void wish(String name)
    {

        try {
            for (int i = 1; i <= 5; i++) 
            {
                System.out.println("Good Morning " + name);
                Thread.sleep(1000);
            }
        } 
        catch (InterruptedException e) 
        {}
    }
}

class MyThread extends Thread 
{
    String name;
    WishingMsg msg;

    MyThread(WishingMsg msg, String nm) 
    {
        this.msg = msg;
        name = nm;
    }

    public void run() 
    {
        msg.wish(name);
    }
}

class ThreadSync 
{
    public static void main(String[] args) 
    {
        WishingMsg msg = new WishingMsg();
        MyThread t1 = new MyThread(msg, "Rohit");
        MyThread t2 = new MyThread(msg, "XYZ");
        MyThread t3 = new MyThread(msg, "ABC");
        t1.start();
        t2.start();
        t3.start();
        // t1.run();
        // t2.run();
        // t3.run();
    }
}