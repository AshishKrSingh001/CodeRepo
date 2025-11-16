import java.util.Scanner;
class Dynamic_Array
{
	private int arr[],size;
	Scanner sc = new Scanner(System.in);
	public Dynamic_Array(int size)
	{
		this.size = size;
		arr = new int[size];
	}
	void input()
	{
		System.out.println("Enter "+size+" Array element: ");
		for(int i=0;i<size;i++)
		{
			arr[i] = sc.nextInt();
		}
	}
	void output()
	{
		System.out.println("Array element: ");
		for(int i:arr)
		{
			System.out.print(i+"\t");
		}
		System.out.println(" ");
	}
	void insert(int n)
	{
		int a[] = new int[n+size];
		for(int i=0;i<size;i++)
		{
			a[i]=arr[i];
		}
		arr = a;
		System.out.println("Enter "+size+" more Array element: ");
		for(int i=size;i<size+n;i++)
		{
			arr[i] = sc.nextInt();
		}
	}
}
class a172_dynamic
{
	public static void main(String args[])
	{
		Dynamic_Array ad = new Dynamic_Array(5);
		ad.input();
		ad.output();
		ad.insert(5);
		ad.output();
	}
}