import java.io.*;
public class AShow
{
	public static void main(String[]args) throws Exception
	{
		char ch[] = new char[500];
		FileReader f = new FileReader("A.data");
		f.read(ch);
		for(char c:ch)
		{
			byte b = (byte)c;
			System.out.print(b);
		}
		System.out.println(" ");
	}
}