package p;
class A
{
	public synchronized void show(String str)
	{
		for(int i=1;i<=3;i++)
		{
			System.out.println(str);
			try
			{
				Thread.sleep(1000);
			}
			catch(InterruptedException e)
			{
				System.out.println(e);
			}
		}
	}
}
class B implements Runnable
{
	A a;
	String str;
	B(A a,String str)
	{
		this.a=a;
		this.str = str;
	}
	public void run()
	{
		a.show(str);
	}
}
public class Thread1
{
	public static void main(String []args) throws Exception
	{
		A a = new A();
		Thread t1 = new Thread(new B(a,"1"));
		t1.start();
		//t1.run();
		
		Thread t2 = new Thread(new B(a,"2"));
		t2.start();
		//t2.run();
		
		Thread t3 = new Thread(new B(a,"3"));
		t3.start();
		//t3.run();
		
		Thread t4 = new Thread(new B(a,"4"));
		t4.start();
		//t4.run();
	}
}