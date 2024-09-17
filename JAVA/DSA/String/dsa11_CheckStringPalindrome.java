// package dsa.string.java;
import java.util.Scanner;

public class dsa11_CheckStringPalindrome
{
	public String reverseString(String str)
	{
		String s = new String();
		for(int i=str.length()-1;i>=0;i--)
		{
			s = s + str.charAt(i);
		}
		return s;
	}
	public static void main(String[]args)
	{
		Scanner scan = new Scanner(System.in);
		String str = new String();
		System.out.println("Enter a string :");
		str = scan.nextLine();
		System.out.println("String is : "+str);
		dsa11_CheckStringPalindrome csp = new dsa11_CheckStringPalindrome();
		System.out.println("Reverse String is : "+csp.reverseString(str));
	}
}