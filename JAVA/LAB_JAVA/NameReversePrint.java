import java.io.*;
public class NameReversePrint
{
	public static void main(String args[])
	{
		System.out.println("Enter a String: ");
		String s = new String();
		try
		{
			DataInputStream d = new DataInputStream(System.in);
			s = d.readLine();
			StringBuffer st = new StringBuffer(s);
			st.reverse();
			st.toString();
			for(int i=0;i<st.length();i++)
			{
				System.out.println(st.charAt(i));
				Thread.sleep(1000);
			}
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
}