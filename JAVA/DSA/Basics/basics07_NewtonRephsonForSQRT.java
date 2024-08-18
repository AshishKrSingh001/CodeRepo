package com.basics;

import java.util.Scanner;

public class basics07_NewtonRephsonForSQRT
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		int num;
		System.out.println("Enter a Number: ");
		num = sc.nextInt();
		
		System.out.println("The number "+num+"'s square root is: "+sqrtNewtonRephson(num));
	}
	public static double sqrtNewtonRephson(int num)
	{
		double root=0;
		double x = num;
		while(true)
		{
			root = 0.5 * (x+(num/x));
			if(Math.abs(root-x)<=0.1)
				return root;
			else
				x = root;
		}
	}
}