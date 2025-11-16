//https://www.geeksforgeeks.org/library-management-system-using-switch-statement-in-java/
interface IA
{
	int a=10;
	void morning();
}
interface IB
{
	int b=20;
	void afternoon();
}
interface IC
{
	int c=30;
	void afternoon();
}
interface ID extends IA,IB,IC // Multiple inheritance by interface
{
	int d=40;
	void night();
}
public class A implements ID
{
	public void morning()
	{
		System.out.println("Good morning");
	}
	public void afternoon()
	{
		System.out.println("Good afternoon");
	}
	public void evening()
	{
		System.out.println("Good evening");
	}
	public void night()
	{
		System.out.println("Good night");
	}
	public static void main(String args[])
	{
		A obj = new A();
		System.out.println("Value of a: "+obj.a);
		System.out.println("Value of b: "+obj.b);
		System.out.println("Value of c: "+obj.c);
		System.out.println("Value of d: "+obj.d);
		obj.morning();
		obj.afternoon();
		obj.evening();
		obj.night();
	}
}
