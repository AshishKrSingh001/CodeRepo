package B;
class A
{
	A()
	{
		this(10);
		System.out.println("hello");
	}
	A(int a)
	{
		double d=1;
		for(int i=2;i<=a;i++)
		{
			d=d*i;
		}
		System.out.println("factroial of "+a+":"+d);
	}
	void args(int...a)
	{
		int n=0;
		for(int i:a)
		{
			n=n+i;
		}
		System.out.println("addition: "+n);
	}
	
	
	void add(int a,int b)
	{
		System.out.println("sum1=: "+(a+b));
	}
	void add(int a,float b)
	{
		System.out.println("sum2=: "+(a+b));
	}
	void add(float a,int b)
	{
		System.out.println("sum3=: "+(a+b));
	}
	void add(String a,String b)
	{
		this.add(10,20);
		this.add(10,20.5f);
		System.out.println("sum4=: "+(a+b));
	}
	void add(float a,float b)
	{
		System.out.println("sum5=: "+(a+b));
	}
}

class B
{
	B()
	{
		System.out.println("Base class Constructor");
	}
	void hello()
	{
		System.out.println("Base class method");
	}
	
}
class C extends B
{
	C()
	{
		super();
		System.out.println("Derived class Constructor");
	}
	void hello()
	{
		System.out.println("Derived class method");
	}
}
public class Over
{
	public static void main(String []args)
	{
		A a;
		a=new A(5);
		a.add("aa","bb");
		//A b=new A(6);
		//a.args();
		//B b = new B();
		//b.hello();
		//C c = new C();
		//c.hello();*/
		/*B a = new C();
		a.hello();*/
	}
} 