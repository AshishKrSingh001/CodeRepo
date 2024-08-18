package com.basics;

import java.util.Scanner;

public class basics01_DecimalToAnyBase
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		int num,base;
		System.out.println("Enter the Number: ");
		num = sc.nextInt();
		System.out.println("Enter the base: ");
		base = sc.nextInt();
		System.out.println("Conversion of Number "+anyBaseToDecimal(decimalToAnyBase(num,base),base)+" to Base "+base+" is: "+decimalToAnyBase(num,base));
	}
	public static long decimalToAnyBase(int decNum,int base)
	{
		long resNum = 0;
		byte power = 0;
		while(decNum>0)
		{
			int unitDigit = decNum % base;
			resNum += unitDigit * Math.pow(10,power++);
			decNum /= base;
		}
		return resNum;
	}
	public static long anyBaseToDecimal(long num,int base)
	{
		long resNum = 0;
		byte power = 0;
		while(num>0)
		{
			int unitDigit = (int)num % 10;
			resNum += unitDigit * Math.pow(base,power++);
			num /= 10;
		}
		return resNum;
	}
}