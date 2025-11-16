package com.basics;

import java.util.Scanner;

public class basics03_CheckPrimeOrNot
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		/*
		int num;
		System.out.println("Enter a Number: ");
		num = sc.nextInt();
		checkPrime(num);
		*/
		
		int f_num,l_num;
		System.out.println("Enter first Number: ");
		f_num = sc.nextInt();
		System.out.println("Enter last Number: ");
		l_num = sc.nextInt();
		System.out.println("The prime numbers between "+f_num+" and "+l_num+" is : "+countPrimeBetweenThem(f_num,l_num));
	}
	public static void checkPrime(int num)
	{
		boolean flag = false;
		for(int i=2;i<=num/2;i++)
		{
			if(num%i == 0 && num!=1)
			{
				flag = true;
				break;
			}
		}
		if(flag)
			System.out.println("The number "+num+" is not Prime");
		else
			System.out.println("The number "+num+" is Prime");
	}
	public static int countPrimeBetweenThem(int f_num,int l_num)
	{
		int count = 0;
			
		for(int num=f_num;num<=l_num;num++)
		{
			boolean flag = false;
			for(int i=2;i<=num/2;i++)
			{
				if(num%i == 0)
				{
					flag = true;
					break;
				}
			}
			if(!flag && num != 1)
				count++;
		}
		return count;
	}
}