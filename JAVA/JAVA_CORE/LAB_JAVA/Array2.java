package A;
import java.util.Scanner;
import java.util.Vector;
class Array
{
	Vector v = new Vector();
	void insert(int a)
	{
		v.add(a);
	}
	void show()
	{
		System.out.println("Array: ");
		for(Object element:v)
		{
			System.out.print(element+"\t");
		}
		System.out.println("");
	}
}
class Array1
{
	int arr[] = new int[10];
	int len=0;
	void insert(int a)
	{
		if(len==arr.length)
		{
			int ar[] = new int[len*2];
			for(int i=0;i<len;i++)
			{
				ar[i] = arr[i];
			}
			arr=ar;
		}
		arr[len] = a;
		len++;
	}
	void show()
	{
		System.out.println("Array: ");
		for(int i=0;i<len;i++)
		{
			System.out.print(arr[i]+"\t");
		}
		System.out.println("");
	}
}
public class Array2
{
	public static void main(String []args)
	{
		Array a = new Array();
		a.insert(10);
		a.insert(20);
		a.insert(30);
		a.insert(40);
		a.insert(50);
		a.insert(60);
		a.insert(70);
		a.insert(80);
		a.show();
		
		Array1 b = new Array1();
		b.insert(10);
		b.insert(20);
		b.insert(30);
		b.insert(40);
		b.insert(50);
		b.insert(60);
		b.insert(70);
		b.insert(80);
		b.show();
	}
}