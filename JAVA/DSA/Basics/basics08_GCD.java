package com.basics;

import java.util.Scanner;

public class basics08_GCD
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);

		System.out.println("Enter first Number: ");
		int num1 = sc.nextInt();
		System.out.println("Enter second Number: ");
		int num2 = sc.nextInt();
		
		
		if(num1>0 && num2>0)
		{
			System.out.println("The GCD of number "+num1+" and "+num2+" is: "+findGCD(num1,num2));
			System.out.println("The Euclidean-GCD of number "+num1+" and "+num2+" is: "+findEuclideanGCD(num1,num2));
		}
		else
			System.out.println("please enter a number greater then \'0\'");
	}
	public static int findGCD(int num1,int num2)
	{
		int min = (num1<num2)?num1:num2;
		while((num1%min!=0) || (num2%min!=0))
		{
			min--;
		}
		return min;
	}
	public static int findEuclideanGCD(int num1,int num2)
	{
		if(num1<num2)
		{
			int temp = num1;
			num1 = num2;
			num2 = temp;
		}
		while(num1!=0 && num2!=0)
		{
			int min = num2;
			num2 = num1 - num2;
			num1 = min;
			if(num1<num2)
			{
				int temp = num1;
				num1 = num2;
				num2 = temp;
			}
		}
		return num1;
		
	}
}