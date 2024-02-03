package p;
class C
{
	int a;
	static int b;
	void incre()
	{
		a++;b++;
	}
	void show()
	{
		System.out.println("value of non static variable: "+a+"\nvalue of static variable: "+b);
	}
	
}
public class Static1
{
	public static void main(String []args)
	{
		C c = new C();
		c.incre();
		c.show();
		
		C c1 = new C();
		c1.incre();
		c1.show();
		
		C c2 = new C();
		c2.incre();
		c2.show();
		
		C c3 = new C();
		c3.incre();
		c3.show();
	}
}