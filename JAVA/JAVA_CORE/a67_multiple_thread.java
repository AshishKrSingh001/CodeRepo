//Creating multiple thread
class Thread1 extends Thread
{
    public void run()
    {
        try
        {
            for(char ch='A';ch<='E';ch++)
            {
                System.out.println(ch);
                Thread.sleep(1000);
            }
        }
        catch(InterruptedException e)
        {}

    }
}
class Thread2 extends Thread
{
    public void run()
    {
        try
        {
            for(char ch='a';ch<='e';ch++)
            {
                System.out.println(ch);
                Thread.sleep(1000);
            }
        }
        catch(InterruptedException e)
        {}
        
    }
}
class Thread3 extends Thread
{
    public void run()
    {
        try
        {
            for(int ch=1;ch<=5;ch++)
            {
                System.out.println(ch);
                Thread.sleep(1000);
            }
        }
        catch(InterruptedException e)
        {}
        
    }
}
public class a155_multiple_thread
{
    public static void main(String[] args) 
    {
        Thread1 t1 = new Thread1();
       
        Thread2 t2 = new Thread2();
        
        Thread3 t3 = new Thread3();
        
        t1.start();
        t2.start();
        t3.start();
        // t3.run();
        // t1.run();
        // t2.run();
        System.out.println("Name of Thread="+Thread.currentThread());
        System.out.println("Only name of main Thread="+Thread.currentThread().getName());
        System.out.println("Default name of Thread1="+t1.getName());
        System.out.println("Default name of Thread2="+t2.getName());
        System.out.println("Default name of Threadt3="+t3.getName());

        t1.setName("Virat");
        t2.setName("Rohit");
        t3.setName("Dhoni");

        System.out.println("Name of threadone="+t1.getName());
        System.out.println("Name of threadtwo="+t2.getName());
        System.out.println("Name of threadthree="+t3.getName());

        System.out.println("\nDefault priority of Main Thread: "+Thread.currentThread().getPriority());
        System.out.println("Default priority of Thread1: "+t1.getPriority());
        System.out.println("Default priority of Thread2: "+t2.getPriority());
        System.out.println("Default priority of Thread3: "+t3.getPriority());

        t1.setPriority(10);
        t2.setPriority(9);
        t3.setPriority(8);

        System.out.println("Priority of Thread1: "+t1.getPriority());
        System.out.println("Priority of Thread2: "+t2.getPriority());
        System.out.println("Priority of Thread3: "+t3.getPriority());
        
        System.out.println("Current state of Thread: "+t1.getState());

        try
        {
            t1.setPriority(12);// generating exception as IllegalArgumentException
            t1.start();
            t1.start();// generates exception as IllegalThreadStateException
        }
        // catch(IllegalArgumentException e)
        // {
        //     System.out.println("Invalid priority:"+e);
        // }
        catch(IllegalThreadStateException n)
        {
            System.out.println("Cannot start multiple times "+n);
        }
        catch(Exception e)
        {
            System.out.println(e);
        }
        
        
    }
}