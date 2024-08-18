package dsa.array.java;

import dsa.array.array01_ArrayFunctions;

public class array09_ResizeArrayExample
{
	public static void main(String[]args)
	{
		dsa01_ArrayFunctions af = new dsa01_ArrayFunctions();
		int n = 4;
		int A[] = new int[n];
		af.inputInArray(A);
		af.outputInArray(A);
		A = af.resizeArray(A,8);
		af.outputInArray(A);
	}
}