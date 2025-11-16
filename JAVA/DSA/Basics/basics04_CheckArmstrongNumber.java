package com.basics;

import java.util.Scanner;

public class basics04_CheckArmstrongNumber
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		int num;
		System.out.println("Enter a Number: ");
		num = sc.nextInt();
		checkArmstrong(num);
	}
	public static void checkArmstrong(int num)
	{
		int resNum = 0;
		int n = num;
		while(n>0)
		{
			int unitDIgit = n%10;
			resNum += Math.pow(unitDIgit,3);
			n /= 10;
		}
		if(resNum==num)
			System.out.println("The number "+num+" is Armstrong");
		else
			System.out.println("The number "+num+" is not Armstrong");
	}
}