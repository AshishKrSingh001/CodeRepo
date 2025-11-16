import java.io.*;
public class NameReversePrint
{
	public Static void main(String args[])
	{
		String s = new String();
		try
		{
			DataInputStream d = new DataInputStream(System.in);
			s = d.readLine();
			//s.charArray()
			for(int i=0;i<s.length();i++)
			{
				System.out.print(s.charAt(i));
				Thread.sleep(1000);
			}
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
}