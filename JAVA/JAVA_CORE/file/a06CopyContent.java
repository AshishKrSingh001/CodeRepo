import java.io.*;
class a06CopyContent
{
	a06CopyContent(File f1,File f2) throws Exception
	{
		FileInputStream fin = new FileInputStream(f1);
		FileOutputStream fout = new FileOutputStream(f2);
		try
		{
			int n;
			while((n=fin.read())!=-1)
			{
				fout.write(n);
			}
		}
		finally
		{
			if(fin!=null && fout!=null)
			{
				fin.close();
				fout.close();
			}
			
		}
		System.out.println("File copied");
	}
	public static void main(String []args) throws Exception
	{
		if(args.length==2)
		{
			File f1 = new File(args[0]);
			File f2 = new File(args[1]);
			a06CopyContent a = new a06CopyContent(f1,f2);
		}
		else
		{
			System.out.println("Invalid command Line Arguments:");
		}
	}
}