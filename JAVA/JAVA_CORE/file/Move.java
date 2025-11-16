import java.io.*;
//import java.nio.file.*;
public class Move
{
	public static void main(String args[])
	{
		File f = new File("C:\\Users\\ashis\\OneDrive\\Desktop\\P\\applet");
		System.out.println(f.getName());
		File f2 = new File("C:\\Users\\ashis\\OneDrive\\Desktop\\P\\Directories",f.getName());
		f.renameTo(f2);
	}
}