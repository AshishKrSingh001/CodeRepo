package pack1;
class A
{
	void meth1()
	{
		System.out.println("Hello meth1");
	}
	@Deprecated  //Print warning
	void meth2()
	{
		System.out.println("Hello meth2");
	}
}
public class A02_Deprecated
{
	public static void main(String[]args)
	{
		A a = new A();
		a.meth2();
	}
}