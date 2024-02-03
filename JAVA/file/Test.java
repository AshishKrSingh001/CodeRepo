import java.util.Vector;
public class Test
{
	public static void main(String args[])
	{
		String s = new String("Ashish");
		Vector<String> v = new Vector<String>();
		int i;
		for(i=0;i<5;i++)
		{
			v.add(s);
		}
		i=0;
		for(String str:v)
		{
			System.out.println(str.charAt(i));
			i++;
		}
	}
}