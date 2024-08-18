package dsa.array.java;

import dsa.array.array01_ArrayFunctions;

public class array05_MinOfArray
{
	public static void main(String[]args)
	{
		dsa01_ArrayFunctions af = new dsa01_ArrayFunctions();
		int n = 5;
		int A[] = new int[n];
		af.inputInArray(A);
		af.outputInArray(A);
		System.out.println("Minimum value is "+af.findMin(A));
	}
}