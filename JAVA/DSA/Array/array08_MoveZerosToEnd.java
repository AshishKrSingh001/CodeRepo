package dsa.array.java;

import dsa.array.array01_ArrayFunctions;

public class array08_MoveZerosToEnd
{
	public static void main(String[]args)
	{
		dsa01_ArrayFunctions af = new dsa01_ArrayFunctions();
		int n = 8;
		int A[] = new int[n];
		af.inputInArray(A);
		af.outputInArray(A);
		af.moveZeroToEnd(A);
		af.outputInArray(A);
	}
}