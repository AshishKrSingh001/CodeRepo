package dsa.array.java;

import dsa.array.array01_ArrayFunctions;
import java.util.*;

public class array02_ArrayIntroduction
{
	public static void main(String[]args)
	{
		System.out.println("Hi");
		array01_ArrayFunctions af = new array01_ArrayFunctions();
		int n;
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter size of an array: ");
		n = sc.nextInt();
		
		int Arr[] = new int[n];
		af.inputInArray(Arr);
		af.outputInArray(Arr);
		System.out.println("Bye");
	}
}