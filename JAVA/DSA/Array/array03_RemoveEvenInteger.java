package dsa.array.java;

import java.util.Scanner;
import dsa.array.array01_ArrayFunctions;

public class array03_RemoveEvenInteger
{	
	public static void main(String []args)
	{
		array01_ArrayFunctions af = new array01_ArrayFunctions();
		int n = 5;
		int Arr[] = new int[n];
		af.inputInArray(Arr);
		af.outputInArray(Arr);
		int A[] = af.removeEvenInteger(Arr);
		af.outputInArray(A);
	}
}

