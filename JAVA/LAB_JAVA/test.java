class test
{
	public int y=10;
	static int a=2;
	public void method()
	{
		 int z=2;
	}
	
	
}
class test2 extends test
{
	test2()
	{
		y++;
		a--;
	}

}
class test3
{

	public static void main(String[] args)
	{
		

		test t = new test();
		System.out.println("value of y = "+t.y);
		System.out.println("value of a = "+t.a);
		test2 t2 = new test2();
		System.out.println("value of y = "+t2.y);
		System.out.println("value of a = "+t2.a);
	}
}