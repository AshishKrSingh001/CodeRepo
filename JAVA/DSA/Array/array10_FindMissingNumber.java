package dsa.array.java;

import dsa.array.array01_ArrayFunctions;

public class array10_FindMissingNumber
{
	public static void main(String[]args)
	{
		dsa01_ArrayFunctions af = new dsa01_ArrayFunctions();
		int n = 6;
		int A[] = new int[n];
		af.inputInArray(A);
		af.outputInArray(A);
		System.out.println("Missing Number Present is: "+af.findMissingNumber(A));
	}
}