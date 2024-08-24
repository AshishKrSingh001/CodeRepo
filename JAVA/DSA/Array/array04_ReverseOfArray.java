package dsa.array.java;

import dsa.array.dsa01_ArrayFunctions;

public class dsa04_ReverseOfArray
{
	public static void main(String[]args)
	{
		array01_ArrayFunctions af = new array01_ArrayFunctions();
		int n = 5;
		int A[] = new int[5];
		af.inputInArray(A);
		af.outputInArray(A);
		A = af.reverseOfArray(A);
		af.outputInArray(A);
	}
} 