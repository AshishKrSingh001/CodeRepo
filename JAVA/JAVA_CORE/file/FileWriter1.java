package p;
import java.util.Scanner;
import java.io.FileWriter;
import java.io.IOException;

public class FileWriter1
{
	public static void main(String []args)
	{
		String name = new String();
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter name: ");
		name = sc.nextLine();
		try(FileWriter fout = new FileWriter("aaa"))
		{
			fout.write(name);
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
}