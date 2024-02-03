package q;
import java.io.*;
class ReadInByte
{
	ReadInByte(String str)
	{
		File f = new File(str);
		int i;
		try(FileInputStream fout = new FileInputStream(f))
		{
			while((i=fout.read())!=-1)
			{
				System.out.print((char)i);
			}
			System.out.println(" ");
		}
		catch(IOException e)
		{}
		finally
		{
			System.out.println("ReadInByte");
		}
	}
}
class ReadInChar
{
	ReadInChar(String str)
	{
		File f = new File(str);
		char c[]= new char[2000];
		try(FileReader fout = new FileReader(f))
		{
			fout.read(c);
			for(char ch:c)
			{
				System.out.print(ch);
			}
			System.out.println(" ");
		}
		catch(IOException e)
		{}
		finally
		{
			System.out.println("ReadInChar");
		}
	}
}
class WriteInWriter
{
	WriteInWriter(String str,String s)
	{
		File f = new File(str);
		try(FileWriter fout = new FileWriter(f))
		{
			fout.write(s.toCharArray());
		}
		catch(IOException e)
		{}
		finally
		{
			System.out.println("WriteInWriter");
		}
	}
}
class WriteInStream
{
	WriteInStream(String str,String s)
	{
		File f = new File(str);
		try(FileOutputStream fout = new FileOutputStream(f))
		{
			byte b[]=s.getBytes();
			for(int i=0;i<b.length;i++)
			{
				fout.write(b[i]);
			}
		}
		catch(IOException e)
		{}
		finally
		{
			System.out.println("WriteInStream");
		}
	}
}
public class FileObject
{
	public static void main(String args[])
	{
		
		String str = "ASHISH KUMAR SINGH";
		String str2 = "ashish kumar singh";
		WriteInWriter w = new WriteInWriter("123",str);
		WriteInStream s1 = new WriteInStream("234",str2);
		ReadInByte b = new ReadInByte("123");
		ReadInByte b1 = new ReadInByte("234");
		//System.out.println("\n\n\n");
		ReadInChar c = new ReadInChar("234");
		ReadInChar c1 = new ReadInChar("123");
	}
}