package com.basics;

import java.util.Scanner;

public class basics05_CheckPalindromeNumber
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		int num;
		System.out.println("Enter a Number: ");
		num = sc.nextInt();
		checkPalindrome(num);
	}
	public static int reverseOfNumber(int num)
	{
		int rev = 0;
		while(num>0)
		{
			int unitDigit = num % 10;
			rev = rev*10 + unitDigit;
			num /= 10;
		}
		return rev;
	}
	public static void checkPalindrome(int num)
	{
		if(reverseOfNumber(num)==num)
			System.out.println("The number "+num+" is Palindrome");
		else
			System.out.println("The number "+num+" is Not Palindrome");
	}
}