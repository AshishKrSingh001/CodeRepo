package output;
import emp.InvalidGenderException;
import emp.InvalidIdException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.BufferedReader;
import java.io.FileOutputStream;
import java.io.ObjectOutputStream;
import emp.Employee1;
import java.io.File;
import java.io.FileNotFoundException;

class InvalidChooseException extends Exception
{
	public InvalidChooseException()
	{
		super("Invalid choice");
	}
}

abstract class Entry
{
	protected String name;// = new String();
	protected char gen;	
	protected String comName;// = new String();
	protected int id;
	protected String post;// = new String();
	protected float salary;
	private BufferedReader b;
	//public abstract void WriteInFile();
	public Entry()
	{
		name = new String();
		comName = new String();
		post = new String();
		b = new BufferedReader(new InputStreamReader(System.in));
	}
	protected void input()
	{
		try
		{
			System.out.println("Enter name of Employee: ");
			name = b.readLine();
			System.out.println("Enter gender of Employee: ");
			gen = (char)b.read();
			if(gen!='m' && gen!='M' && gen!='f' && gen!='F')
			{
				throw (new InvalidGenderException()); 
			}
			b.readLine();
			System.out.println("Enter company name of Employee: ");
			comName = b.readLine();
			System.out.println("Enter id of Employee: ");
			id = Integer.parseInt(b.readLine());
			if(id<0)
			{
				throw (new InvalidIdException("Id cannot be negative"));
			}
			System.out.println("Enter post of Employee: ");
			post = b.readLine();
			System.out.println("Enter salary of Employee: ");
			salary = Float.parseFloat(b.readLine());
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
	public boolean choose() throws Exception
	{
		System.out.println("Do you want to enter More(y/n):");
		char ch = (char)b.read();
		b.readLine();
		if(ch=='y' || ch=='Y')
		{
			return true;
		}
		else if(ch=='N' || ch=='n')
		{
			return false;
		}
		else
		{
			throw (new InvalidChooseException());
		}
	}
}
public class Output extends Entry
{
	private File f;
	private FileOutputStream fout;
	private ObjectOutputStream out;
	public Output(String filename) throws Exception
	{
		f = new File(filename);
		fout = new FileOutputStream(f);
		out = new ObjectOutputStream(fout);
	}
	public void writeInFile()
	{
		Employee1 emp = new Employee1();
		try
		{
			while(true)
			{
				input();
				emp.setName(name);
				emp.setGen(gen);
				emp.setComName(comName);
				emp.setId(id);
				emp.setPost(post);
				emp.setSalary(salary);
				out.writeObject(emp);
				if(!choose())
				{
					break;
				}
			}
			System.out.println("File Writing completed");
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
		try
		{
			out.flush();
			out.close();
			fout.close();
		}
		catch(Exception q)
		{
			System.out.println(q);
		}
	}
	public static void main(String args[])
	{
		try
		{
			Output out = new Output("emp.data");
			out.writeInFile();	
		}
		catch(FileNotFoundException e)
		{
			System.out.println(e);
		}
		catch(IOException e)
		{
			System.out.println(e);
		}
		catch(Exception e)
		{
			System.out.println(e);
		}		
	}
}