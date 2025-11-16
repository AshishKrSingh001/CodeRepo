package pack;
import java.io.*;
public class FormattedDataRead
{
	private File f;
	private FileInputStream fin;
	private ObjectInputStream oin;
	
	public FormattedDataRead(String fileName) throws Exception
	{
		f = new File(fileName);
		fin = new FileInputStream(f);
		oin = new ObjectInputStream(fin);
	}
	public void readFromFile() throws Exception
	{
		Employee emp = (Employee) oin.readObject(); 
		System.out.println(emp.toString());
		fin.close();
		oin.close();
	}
	
	public static void main(String args[]) throws Exception
	{
		FormattedDataRead f = new FormattedDataRead("A.data");
		f.readFromFile();
	}
}