// package dsa.array;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class array_MultiDArray
{
	public static void inputInMultiDArray(int A[][])
	{
		Scanner sc = new Scanner(System.in);
		
		System.out.println("**********Input**********\nEnter "+A.length+"X"+A[0].length+" numbers in an array: ");
		for(int i=0;i<A.length;i++)
		{
			for(int j=0;j<A[i].length;j++)
			{
				A[i][j] = sc.nextInt();
			}
		}
		System.out.println("**********Input-End***********");
	}
	
	public static void outputInMultiDArray(int A[][])
	{
		System.out.println("**********Output-Start***********\nArray elements are:");
		for(int i=0;i<A.length;i++)
		{
			for(int j=0;j<A[i].length;j++)
			{
				System.out.print(A[i][j]+"\t");
			}
			System.out.println("");
		}
		System.out.println("\n**********Output-End***********");
	}
	public static void main(String[]args)
	{
		System.out.println("Hello");
	}
	public static int[][] insertInMultiDArray(int A[][],int row,int x,int element)
	{
		if((row<0 || row>A.length-1)||(x<0 || x>A.length-1))
		{
			System.out.println("Invalid Position");
			return A;
		}
		else
		{
			int myArr[][] = new int[A.length][];
			for(int i=0;i<A.length;i++)
			{
				if(i==row)
				{
					myArr[i] = new int[(A[i].length+1)];
				}
				else
				{
					myArr[i] = new int[A[i].length];
				}
			}
			for(int i=0;i<A.length;i++)
			{
				if(i==row)
				{
					for(int j=0;j<x;j++)
					{
						myArr[i][j] = A[i][j];
					}
					myArr[row][x] = element;
					for(int j=x;j<A[i].length;j++)
					{
						myArr[i][++x] = A[i][j];
					}
				}
				else
				{
					for(int j=0;j<A[i].length;j++)
					{
						myArr[i][j] = A[i][j];
					}
				}
			}
			return myArr;
		}
	}
	public static int[][] deleteInMultiDArray(int A[][],int row,int x)
	{
		if((row<0 || row>A.length-1)||(x<0 || x>A.length-1))
		{
			System.out.println("Invalid Position");
			return A;
		}
		else
		{
			int myArr[][] = new int[A.length][];
			for(int i=0;i<A.length;i++)
			{
				if(i==row)
				{
					myArr[i] = new int[(A[i].length-1)];
				}
				else
				{
					myArr[i] = new int[A[i].length];
				}
			}
			for(int i=0;i<A.length;i++)
			{
				if(i==row)
				{
					for(int j=0;j<x;j++)
					{
						myArr[i][j] = A[i][j];
					}
					for(int j=x+1;j<A[i].length;j++)
					{
						myArr[i][x] = A[i][j];x++;
					}
				}
				else
				{
					for(int j=0;j<A[i].length;j++)
					{
						myArr[i][j] = A[i][j];
					}
				}
			}
			return myArr;
		}
	}
	public static void linearSearchAtPosition(int A[][],int searchElement,boolean lastPosition)
	{
		int row = -1;
		int x = -1;
		for(int i=0;i<A.length;i++)
		{
			for(int j=0;j<A[i].length;j++)
			{
				if(A[i][j] == searchElement)
				{
					row = i;
					x = j;
					if(lastPosition==false)
						break;
				}
			}
		}
		if(row==-1)
		{
			System.out.println("Not Found");
		}
		else
		{
			System.out.println("Found at "+row+"X"+x+" Position");
		}
	}
	public static void maximumSumOfRow(int A[][])
	{
		int max=0,row=-1;
		for(int i=0;i<A.length;i++)
		{
			int sum = 0;
			for(int j=0;j<A[i].length;j++)
			{
				sum = sum + A[i][j]; 
			}
			if(max<sum)
			{
				max = sum;
				row = i;
			}
		}
		System.out.println("Maximum Sum present at Row : "+row+" and value is: "+max);
	}
	static boolean search(int matrix[][], int n, int m, int x) 
	{
	    for(int i=0;i<n;i++)
	    {
	        int res = ternarySearch(matrix[i],x);
	        if(res != -1)
	            return true;
	    }
	    return false;
	}
	public static int ternarySearch(int A[], int target)
	{
		int start = 0;
		int end = A.length-1;
		while(start<=end)
		{
			int mid1 = start + (end - start) / 3;
			int mid2 = end - (end - start)/3;

			if(A[mid1] >= target)
			{
				if(A[mid1] == target)
					return mid1;
				end = mid1 - 1;
			}
			else if(A[mid2] <= target)
			{
				if(A[mid2] == target)
					return mid2;
				start = mid2 + 1;
			}
			else
			{
				start = mid1 + 1;
				end = mid2 - 1;
			}
		}
		return -1;
	}
	public static int median(int matrix[][], int R, int C) 
	{
        int start = 1;
		int end = 2000;
		int medianIndex = R * C / 2; 
		while(start <= end)
		{
			int assumedMedian = start + (end - start) / 2;
			int noOfSmallerElement = countSmallerElement(matrix, assumedMedian);
			if(noOfSmallerElement <= medianIndex)
				start = assumedMedian + 1;
			else
				end = assumedMedian - 1;
		}
		return start; 
    }
	public static int countSmallerElement(int A[][],int assumedMedian)
	{
		int noOfSmallerElement = 0;
		for(int i=0;i<A.length;i++)
		{
			int start = 0;
			int end = A[i].length -1;
			while(start <= end)
			{
				int mid = start + (end - start) / 2;
				if(A[i][mid] <= assumedMedian)
					start = mid + 1;
				else
					end = mid - 1;
			}
			noOfSmallerElement += start;
		}
		return noOfSmallerElement;
	}
	public static int kthSmallest(int[][] matrix, int k) 
    {
		int start = matrix[0][0];
		int end = matrix[matrix.length-1][matrix[0].length-1];
		k -= 1;
		while(start <= end)
		{
			int assumedMedian = start + (end - start) / 2;
			int noOfSmallerElement = countSmallerElement(matrix, assumedMedian);
			if(noOfSmallerElement <= k)
				start = assumedMedian + 1;
			else
				end = assumedMedian - 1;
		}
		return start; 
    }
	public static boolean searchInSortedMatrix(int[][] matrix, int target) 
	{
		if(matrix.length == 0)
			return false;
		int n = matrix.length;
		int m = matrix[0].length;
		int start = m;
		int  end = n * m - 1;

		while(start <= end)
		{
			int mid = start + (end - start) / 2;
			int R = mid / m;
			int C = mid % m;
			int val = matrix[R][C];
			if(val == target)
				return true;
			else if(val > target)
				end = mid - 1;
			else
				start = mid + 1;
		}
		return false;
    }
	public static boolean searchMatrixRowColSorted(int[][] matrix, int target) 
	{
		if(matrix.length == 0)
			return false;
		int r = 0;
		int c = matrix[0].length - 1;

		while(r < matrix.length && c >= 0)
		{
			int val = matrix[r][c];
			if(val == target)
				return true;
			else if(val > target)
				c--;
			else
				r++;
		}
		return false;
    }
	public static void transposeMatrix(int A[][])
	{
		for(int i=0;i<A.length;i++)
		{
			for(int j=i;j<A[0].length;j++)
			{
				if(i != j)
				{
					int temp = A[i][j];
					A[i][j] = A[j][i];
					A[j][i] = temp;
				}

			}
		}
	}
	public static void rotateMatrixClockWise(int A[][])
	{
		// transposeMatrix(A);
		int n = A.length-1;
		
		for(int i=0;i<=n;i++)
		{
			for(int j=0;j<=A.length/2-1;j++)
			{
				int temp = A[i][j];
				A[i][j] = A[i][n-j];
				A[i][n-j] = temp;
			}
		}
	}
	public static void rotateMatrixAntiClockWise(int A[][])
	{
		// transposeMatrix(A);
		int n = A.length-1;
		
		for(int i=0;i<=A.length/2-1;i++)
		{
			for(int j=0;j<=n;j++)
			{
				int temp = A[i][j];
				A[i][j] = A[n-i][j];
				A[n-i][j] = temp;
			}
		}
	}
	public static List<Integer> spiralOrder(int[][] A) 
    {
        List<Integer> res = new ArrayList<>();

		int rowStart = 0;
		int rowEnd = A.length-1;
		int colStart = 0;
		int colEnd = A[0].length-1;
		while((rowStart <= rowEnd && colStart <= colEnd))
		{

			for(int j=colStart;j<=colEnd;j++)
			{
				res.add(A[rowStart][j]);
			}
			rowStart++;
			if (rowStart > rowEnd) {break;}

			for(int i=rowStart;i<=rowEnd;i++)
			{
				res.add(A[i][colEnd]);
			}
			colEnd--;
			if (colStart > colEnd) {break;}

			for(int j=colEnd;j>=colStart;j--)
			{
				res.add(A[rowEnd][j]);
			}
			rowEnd--;
			if (rowStart > rowEnd) {break;}
			for(int i=rowEnd;i>=rowStart;i--)
			{
				res.add(A[i][colStart]);
			}
			colStart++;
		}
		return res;
    }
	public static int[][] generateSpiralMatrix(int n) 
    {
		int A[][] = new int[n][n];
        int rowStart = 0;
		int rowEnd = n-1;
		int colStart = 0;
		int colEnd = n-1;
		int element = 0;
		while((rowStart <= rowEnd && colStart <= colEnd))
		{

			for(int j=colStart;j<=colEnd;j++)
			{
				A[rowStart][j] = ++element;
			}
			rowStart++;
			if (rowStart > rowEnd) {break;}

			for(int i=rowStart;i<=rowEnd;i++)
			{
				A[i][colEnd] = ++element;
			}
			colEnd--;
			if (colStart > colEnd) {break;}

			for(int j=colEnd;j>=colStart;j--)
			{
				A[rowEnd][j] = ++element;
			}
			rowEnd--;
			if (rowStart > rowEnd) {break;}
			for(int i=rowEnd;i>=rowStart;i--)
			{
				A[i][colStart] = ++element;
			}
			colStart++;
		}
		return A;
    
    }
}
