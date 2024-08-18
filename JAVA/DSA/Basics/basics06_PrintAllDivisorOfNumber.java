package com.basics;

import java.util.Scanner;

public class basics06_PrintAllDivisorOfNumber
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		int num;
		System.out.println("Enter a Number: ");
		num = sc.nextInt();
		
		printAllDivisor(num);
	}
	public static void printAllDivisor(int num)
	{
		System.out.println("Number divisor of "+num+" is: ");
		for(int i=1;i<=num;i++)
		{
			if(num%i==0)
			{
				System.out.print(i+"\t");
			}
		}
	}
}