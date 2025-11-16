package A;
class A
{
	A()
	{
		System.out.println("Costructor");
	}
	void method()
	{
		System.out.println("method");
	}
}
public class ObjectArray
{
	public static void main(String[]args)
	{
		System.out.println("Hi");
		A a[] = new A[10];
		for(int i=0;i<10;i++)
		{
			a[i] = new A();
			a[i].method();
		}
		System.out.println("Bye");
	}
}