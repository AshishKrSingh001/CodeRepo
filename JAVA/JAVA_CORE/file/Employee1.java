package emp;
import emp.InvalidGenderException;
import emp.InvalidIdException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.Serializable;


public class Employee1 implements Serializable
{
	private String name = new String();
	private char gen;
	private String comName = new String();
	private int id;
	private String post = new String();
	private float salary;
	public void setName(String name)
	{
		this.name = name;
	}
	public void setGen(char gen) throws InvalidGenderException
	{
		this.gen = gen;
		if(gen!='m' && gen!='M' && gen!='f' && gen!='F')
		{
			throw (new InvalidGenderException()); 
		}
	}
	public void setComName(String comName)
	{
		this.comName = comName;
	}
	public void setId(int id) throws InvalidIdException
	{
		this.id = id;
		if(id<0)
		{
			throw (new InvalidIdException("Id cannot be negative"));
		}
	}
	public void setPost(String post)
	{
		this.post = post;
	}
	public void setSalary(float salary)
	{
		this.salary = salary;
	}
	public void output()
	{
		System.out.println("\nEmployee\'s details:"+"\nName: "+name+"\nGender: "+gen+"\nCompany name: "+comName+"\nId: "+id+"\nPost: "+post+"\nSalary: "+salary);
	}
}