package input;
import emp.InvalidGenderException;
import emp.InvalidIdException;
import java.io.IOException;
import java.io.FileInputStream;
import java.io.ObjectInputStream;
import emp.Employee1;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.io.EOFException;
public class Input
{
	private File f;
	private FileInputStream fin;
	private ObjectInputStream in;
	ArrayList <Employee1> a = new ArrayList<>();  
	public Input(String filename) //throws Exception
	{
		try
		{
			f = new File(filename);
			fin = new FileInputStream(f);
			in = new ObjectInputStream(fin);
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
	public void readFromFile()
	{
		while(true)
		{
			try
			{
				Employee1 emp = (Employee1) in.readObject();
				a.add(emp);
			}
			catch(EOFException e)
			{
				System.out.println("\n"+e);
				break;
			}
			catch(IOException e)
			{
				System.out.println(e);
				break;
			}
			catch(Exception e)
			{
				System.out.println(e);
				break;
			}
		}
		try
		{
			fin.close();
			in.close();
			for(Employee1 e:a)
			{
				e.output();
			}
		}
		catch(IOException e)
		{
			System.out.println(e);
		}
	}
	public static void main(String args[])
	{
		Input in = new Input("emp.data");
		in.readFromFile();
		
	}
}

