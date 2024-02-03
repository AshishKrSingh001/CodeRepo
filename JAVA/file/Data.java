package pack;
import java.io.*;
class Employee implements Serializable
{
	private String name;
	private int id;
	public Employee()
	{
		name = new String();
	}
	public void setName(String name)
	{
		this.name = name;
	}
	public void setId(int id)
	{
		this.id = id;
	}
	public String getName()
	{
		return name;
	}
	public int getId()
	{
		return id;
	}
	
}

class WriteFormattedData
{
	private File f;
	private FileOutputStream fout;
	private ObjectOutputStream out;
	private BufferedReader b;
	
	public WriteFormattedData(String fileName) throws Exception
	{
		f = new File(fileName);
		fout = new FileOutputStream(f,true);
		out = new ObjectOutputStream(fout);
		b = new BufferedReader(new InputStreamReader(System.in));
	}
	public void writeInFile() throws Exception
	{
		Employee emp[] = new Employee[5];
		for(int i=0;i<5;i++)
		{
			emp[i] = new Employee();
			System.out.println("Enter name: ");
			emp[i].setName(b.readLine());
			System.out.println("Enter Id: ");
			emp[i].setId(Integer.parseInt(b.readLine()));
			out.writeObject(emp[i]);
		}
		fout.close();
		out.close();
		
	}
}
	
class ReadFormattedData
{
	private File f;
	private FileInputStream fin;
	private ObjectInputStream in;
	
	public ReadFormattedData(String fileName) throws Exception
	{
		f = new File(fileName);
		fin = new FileInputStream(f);
		in = new ObjectInputStream(fin);
	}
	public void readInFile() throws Exception
	{
		while(true)
		{
			try
			{
				Employee obj = (Employee)in.readObject();
				System.out.println("\nName: "+obj.getName()+"\nId: "+obj.getId());
			}
			catch(EOFException e)
			{break;}
		}
		//Employee emp = (Employee) in.readObject();
		//System.out.println("\nName: "+emp.getName()+"\nId: "+emp.getId());
		fin.close();
		in.close();
		
	}
}
public class Data
{
	
	public static void main(String args[]) throws Exception
	{
		WriteFormattedData f = new WriteFormattedData("A.data");
		f.writeInFile();
		
		ReadFormattedData f1 = new ReadFormattedData("A.data");
		f1.readInFile();
	}
}