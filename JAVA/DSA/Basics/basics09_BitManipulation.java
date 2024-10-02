package com.basics;

import java.util.Scanner;

public class basics09_BitManipulation
{
	public static void main(String[]args)
	{
		Scanner sc = new Scanner(System.in);
		int num,bit;
		System.out.println("Enter a Number: ");
		num = sc.nextInt();
		//System.out.println("Enter Bit position: ");
		//bit = sc.nextInt();
		
		printBits(num);
		//findEvenOdd(num);
		//int set = setIthBit(num,bit);
		//printBits(set);
		//int unSet = unSetIthBit(num,bit);
		//printBits(unSet);
		//int toggle = toggleIthBit(num,bit);
		//printBits(toggle);
		
		//checkNumIsPowerOf2(num);
		
		int n = unSetRightMostSetBit(num);
		printBits(n);
		
	}
	public static void printBits(int num)
	{
		for(int i=7;i>=0;i--)
		{
			System.out.print(((num>>i) & 1)+"\t");
		}
		System.out.println("");
	}
	public static void findEvenOdd(int num)
	{
		if(isBitSet(num,0))
			System.out.println("The number "+num+" is Odd");
		else
			System.out.println("The number "+num+" is Even");
	}
	public static boolean isBitSet(int num,int bit)
	{
		int res = num & (1<<bit);
		return (res==0)?false:true;
	}
	public static int setIthBit(int num,int bit)
	{
		return num | (1<<bit);
	}
	public static int unSetIthBit(int num,int bit)
	{
		return num & ~(1<<bit);
	}
	public static int toggleIthBit(int num,int bit)
	{
		return num ^ (1<<bit);
	}
	public static void checkNumIsPowerOf2(int num)
	{
		if((num & (num-1))==0)
			System.out.println("The number "+num+" is Power of 2");
		else
			System.out.println("The number "+num+" is not Power of 2");
	}
	public static int unSetRightMostSetBit(int num)
	{
		return (num & (num-1));
	}
	public static int clearLSB(int num, int i)
    {
        return (num & ~((1<<(i+1))-1));
    }
    public static int clearMSB(int num, int i)
    {
        return (num & ((1<<(i+1))-1));
    }
	public static void printBitsOfChar(char ch)
    {
        for(int i=7;i>=0;i--)
        {
            System.out.print(((int)ch>>i) & 1);
        }System.out.println("");
    }
    public static char lowerToUpper(char ch)
    {
        return (char)((int)ch & ~(1<<5));
    }
    public static char upperToLower(char ch)
    {
        return (char)((int)ch | (1<<5));
    }
}