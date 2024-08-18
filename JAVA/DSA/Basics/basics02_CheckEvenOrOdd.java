package com.basics;

import java.util.Scanner;

public class basics02_CheckEvenOrOdd
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		int num;
		System.out.println("Enter a Number: ");
		num = sc.nextInt();
		
		checkEvenOdd(num);
	}
	public static void checkEvenOdd(int num)
	{
		if(num % 2 == 0)
			System.out.println("The number "+num+" is Even");
		else
			System.out.println("The number "+num+" is Odd");
	}
}