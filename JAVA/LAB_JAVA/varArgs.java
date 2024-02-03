public class varArgs
{
	public static int add(int...a)
	{
		int sum=0;
		for(int i:a)
		{
			sum=sum+i;
		}
		return sum;
	}
	public static void main(String args[])
	{
		System.out.println("Sum of n number: "+add(10,20,30,40,50,60,70,80,90,100));
		System.out.println("Sum of n number: "+add(11,12,13,14,15));
	}
}