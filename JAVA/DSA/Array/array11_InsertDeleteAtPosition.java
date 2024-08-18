package dsa.array.java;

import dsa.array.array01_ArrayFunctions;

public class array11_InsertDeleteAtPosition
{
	public static void main(String[]args)
	{
		array01_ArrayFunctions af = new array01_ArrayFunctions();
		int n = 5;
		int A[] = new int[n];
		af.inputInArray(A);
		af.outputInArray(A);
		/*
		A = af.insertAtPosition(A,15,999);
		af.outputInArray(A);
		A = af.insertAtPosition(A,0,888);
		af.outputInArray(A);
		A = af.insertAtPosition(A,3,777);
		af.outputInArray(A);
		A = af.insertAtPosition(A,1,666);
		af.outputInArray(A);
		*/
		A = af.deleteAtPosition(A,15);
		af.outputInArray(A);
		A = af.deleteAtPosition(A,0);
		af.outputInArray(A);
		A = af.deleteAtPosition(A,3);
		af.outputInArray(A);
		A = af.deleteAtPosition(A,1);
		af.outputInArray(A);
	}
	
}