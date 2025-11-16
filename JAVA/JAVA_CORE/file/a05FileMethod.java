import java.io.*;
class a05FileMethod
{
	File f;
	void filemethods(String str) //throws IOException
	{
		f = new File(str);
		//setReadOnly()
		f.setReadOnly();
		//getName()
		System.out.println("File name: "+f.getName());
		//getPath()
		System.out.println("File Path: "+f.getPath());
		//getAbsolutePath()
		System.out.println("Absolute Path: "+f.getAbsolutePath());
		//exists()
		System.out.println("Exists: "+f.exists());
		if(f.exists())
		{
			//canWrite()
			System.out.println("Is Writable: "+f.canWrite());
			//canRead()
			System.out.println("Is Readable: "+f.canRead());
			//isDirectory()
			System.out.println("Is a Directory: "+f.isDirectory());
			//length()
			System.out.println("File Size in bytes: "+f.length());
		}
	}
	void dirmethods(String str) throws IOException
	{
		//list();
		f = new File(str);
		System.out.println("Is a Directory: "+f.isDirectory());
		String st[] = new String[10];
		st = f.list();
		for(String s:st)
		{
			System.out.println(s);
		}
		//getParent()
		System.out.println("Parent: "+f.getParent());//return String
		//getParentFile()
		System.out.println("Parent: "+f.getParentFile());//return File
		//mkdir()
		File f1 = new File("D:\\programming\\Java\\file\\f");
		f1.mkdir();
		//createNewFile()
		File f2 = new File("D:\\programming\\Java\\file\\aaa.aaa");
		f2.createNewFile();
		System.out.println("List of File//Dir in the Directory: "+str);
		
		//renameTo()
		File s1 = new File("D:\\programming\\Java\\file\\B.abc");
		File s2 = new File("D:\\programming\\Java\\file\\BB.abc");
		System.out.println("File name: "+s1.getName());
		s1.renameTo(s2);
		//delete()
		if(f2.exists())
		{
			f2.delete();
		}
		System.out.println("\nList of File//Dir in the Directory: "+str);
		
		//listFiles()
		System.out.println("\nList of File//Dir in the Directory: "+str);
		File a[] = new File[10];
		a = f.listFiles();
		for(File s:a)
		{
			System.out.println(s);
		}
		//getFreeSpace()
		File fol = new File("D:");
		System.out.println("Free space in D: "+(int)fol.getFreeSpace());
		
	}
	
	public static void main(String []args) throws IOException
	{
		a05FileMethod f = new a05FileMethod();
		System.out.println("\nfilemethods();");
		f.filemethods("a05FileMethod.java");
		System.out.println("\ndirmethods();");
		f.dirmethods("D:\\programming\\Java\\file");
	}
}