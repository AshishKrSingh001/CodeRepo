package pack1;
import java.util.*;

public class A02_SuppressWarning
{
	@SuppressWarnings("unchecked") //This will avoid compile time warning; 
	public static void main(String[]args)
	{
		ArrayList list = new ArrayList();
		list.add("Sunday");
		list.add("Monday");
		list.add("Tuesday");
		
		for(Object obj : list)
		{
			System.out.println(obj);
		}
	}
}