
abstract class Engineer
{
	abstract void print();
}
class IT extends Engineer
{
	public void print()
	{
		System.out.println("IT");
	}
}
class Electrical extends Engineer
{
	public void print()
	{
		System.out.println("Electrical");
	}
}
class Chemical extends Engineer
{
	public void print()
	{
		System.out.println("Chemical");
	}
}
class Mechanical extends Engineer
{
	public void print()
	{
		System.out.println("Mechanical");
	}
}
public class test1
{
	Engineer e;
	IT i = new IT();
	Chemical c = new Chemical();
	Mechanical m = new Mechanical();
	Electrical e1 = new Electrical();
	public void disp()
	{
		e=m;//
		if(e instanceof IT)
		{
			e.print();
		}
		else if(e instanceof Chemical)
		{
			e.print();
		}
		else if(e instanceof Electrical)
		{
			e.print();
		}
		else if(e instanceof Mechanical)
		{
			e.print();
		}
	}
	public static void main(String[]args)
	{
		test1 t = new test1();
		t.disp();
		
		
	}
}