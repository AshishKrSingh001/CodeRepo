package A;
public class Strings
{
	String s = new String();
	Strings(String s)
	{
		this.s = s;
	}
	public String reverse()
	{
		char ch[] = new char[20];
		for(int i=s.length()-1,j=0;i>=0;i--,j++)
		{
			ch[j] = s.charAt(i);
		}
		String st = new String(ch);
		return st;
	}	
	public static void main(String[]args)
	{
		System.out.println("Hi");
		Strings s = new Strings("Ashish");
		System.out.println(s.reverse());
		System.out.println("Bye");
	}
}
