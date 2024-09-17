// package dsa.array.java;

import java.util.Scanner;

class BioTonicArray
{
	public static void minValueInBiotonicArray(int A[])
	{
		if(A.length==0)
			System.out.println("Array is Empty");
		else if(A.length==1)
			System.out.println("Minimum value of Biotonic Array is: "+A[0]);
		else
		{
			int min = (A[0]<=A[A.length-1])?A[0]:A[A.length-1];
			System.out.println("Minimum value of Biotonic Array is: "+min);
		}
	}
	public static int maxValueInBiotonicArray(int A[])
	{
		if(A.length==0)
		{
			return -1;
		}
		else if(A.length==1)
		{
			return 0;
		}
		else
		{
			int start = 0;
			int end = A.length-1;
			while(start<=end)
			{
				int mid = (start+end)/2;
				int next = (mid+1)%A.length;
				int prev = (mid-1+A.length)%A.length;
				if(A[mid]>A[prev] && A[mid]>A[next])
					return mid;
				else if(A[mid]>A[prev])
					start = mid+1;
				else if(A[mid]>A[next])
					end = mid-1;
			}
			return -1;
		}
	}
	public static int binarySearchInRange(int A[],int target,int start,int end,boolean asc)
	{
		int pos=-1;
		while(start<=end)
		{
			int mid = (start+end)/2;
			if(A[mid]==target)
			{
				pos=mid;
				break;
			}
			else if(A[mid]>target)
			{
				if(asc)
					end = mid-1;
				else
					start = mid + 1;
			}
			else
				if(asc)
					start = mid+1;
				else
					end = mid - 1;
		}
		return pos;
	}
	public static void searchInBiotonicArray(int A[],int target)
	{
		if(A.length==0)
			System.out.println("Array is Empty");
		else
		{
			int peak = maxValueInBiotonicArray(A);
			if(A[peak]==target)
			{
				System.out.println("Found at position peak : "+peak);
				return;
			}
			int pos1 = binarySearchInRange(A,target,0,peak-1,true);
			int pos2 = binarySearchInRange(A,target,peak+1,A.length-1,true);
			if(pos1==-1 && pos2==-1)
				System.out.println("Not found");
			else if(pos1==-1)
				System.out.println("Found at position: "+pos2);
			else if(pos2==-1)
				System.out.println("Found at position: "+pos1);
			else
				System.out.println("Found at positions: "+pos1+" and "+pos2);
		}
	}	
}
class RotatedArray
{
	public static void rotationCountOfRotatedArray(int A[])
	{
		int index = findMinimumValuePositionInRotatedArray(A);
		System.out.println("Rotation Count: "+index);
	}
	public static int findMaximumValuePositionInRotatedArray(int A[])
	{
		int start = 0;
		int end = A.length-1;
		while(start < end)
		{
			int mid = (start+end)/2;
			if(mid<A.length-1 && A[mid]>A[mid+1])
				return mid;
			else if(A[start] > A[mid])
				end = mid-1;
			else if(A[start] < A[mid])
				start = mid+1;
		}
		return start;
		
	}
	public static int findMinimumValuePositionInRotatedArray(int A[])
	{
		if(A.length==0)
		{
			System.out.println("Array is Empty");
			return -1;
		}
		else if(A.length==1)
		{
			return 0;
		}
		else
		{
			int start = 0;
			int end = A.length-1;
			while(start<end)
			{
				int mid = (start+end)/2;
				if(mid>0 && A[mid]<A[mid-1])
					return mid;
				else if(A[end]>A[mid])
					end = mid-1;
				else if(A[end]<A[mid])
					start = mid+1;
			}
			return start;
		}
	}
}

public class array12_Search
{
	public static void main(String[]args)
	{
		System.out.println("Hello World");
		
	}
	public static void inputInArray(int A[])
	{
		Scanner sc = new Scanner(System.in);
		
		System.out.println("**********Input**********\nEnter "+A.length+" numbers in an array: ");
		for(int i=0;i<A.length;i++)
		{
			A[i] = sc.nextInt();
		}
		System.out.println("**********Input-End***********");
	}
	
	public static  void outputInArray(int A[])
	{
		System.out.println("**********Output-Start***********\nArray elements are:");
		for(int i=0;i<A.length;i++)
		{
			System.out.print(A[i]+"\t");
		}
		System.out.println("\n**********Output-End***********");
	}

	public static void linearSearchGetPosition(int A[],int searchElement,boolean lastPosition)
	{
		int pos=-1;
		for(int i=0;i<A.length;i++)
		{
			if(A[i]==searchElement)
			{
				if(lastPosition)
				{
					pos = i;
				}
				else
				{
					pos=i;
					break;
				}
			}
		}
		if(pos==-1)
		{
			System.out.println("Not Found");
		}
		else
		{
			System.out.println("Found at "+pos+" Position");
		}
	}
	public static void linearSearchGetAllPosition(int A[],int searchElement)
	{
		int myArr[] = new int[A.length];
		int k=-1;
		for(int i=0;i<A.length;i++)
		{
			if(A[i]==searchElement)
			{
				myArr[++k] = i;
			}
		}
		if(k==-1)
		{
			System.out.println("Not Found");
		}
		else
		{
			System.out.println("Found at Position: ");
			for(int i=0;i<=k;i++)
			{
				System.out.print(myArr[i]+"\t");
			}
		}
	}
	public static void binarySearch(int A[],int searchElement)
	{
		int min = 0,max = A.length-1,mid;
		while(min<=max)
		{
			mid = (min+max)/2;
			if(A[mid]>searchElement)
				max = mid-1;
			else if(A[mid]<searchElement)
				min = mid+1;
			else
			{
				System.out.println("Found at "+mid+"th Position");
				break;
			}
		}
		if(min>max)
			System.out.println("Not found");
	}
	public static void binarySearchDesc(int A[],int searchElement)
	{
		int min = 0,max = A.length-1,mid;
		while(min<=max)
		{
			mid = (min+max)/2;
			if(A[mid]>searchElement)
				min = mid + 1;
			else if(A[mid]<searchElement)
				max = mid - 1;
			else
			{
				System.out.println("Found at "+mid+"th Position");
				break;
			}
		}
		if(min>max)
			System.out.println("Not found");
	}
	public static void orderAgnosticBinarySearch(int A[],int searchElement)
	{
		if(A[0]<=A[A.length-1])
		{
			binarySearch(A,searchElement);
		}
		else
		{
			binarySearchDesc(A,searchElement);
		}
	}
	public static void binarySearchAccoToOccurance(int A[],int searchElement,boolean lastOccurance)
	{
		int min = 0,max = A.length-1,mid;
		int pos=-1;
		while(min<=max)
		{
			mid = (min+max)/2;
			if(A[mid]>searchElement)
				max = mid-1;
			else if(A[mid]<searchElement)
				min = mid+1;
			else if(A[mid]==searchElement)
			{
				pos=mid;
				if(lastOccurance==false)
					max = mid-1;
				else
					min = mid+1;
			}
		}
		if(pos!=-1)
			System.out.println("Found at "+pos+"th Position");
		else
			System.out.println("Not found");
	}
	public static int countOccuranceOfElementBS(int A[],int target,boolean lastOccurance)
	{
		int min=0,max=A.length-1,pos=-1,mid;
		while(min<=max)
		{
			mid = (min+max)/2;
			if(A[mid]==target)
			{
				pos=mid;
				if(lastOccurance)
					min = mid+1;
				else
					max = mid-1;
			}
			else if(A[mid]>target)
				max = mid-1;
			else if(A[mid]<target)
				min = mid+1;
		}
		return pos;
	}
	public static int floorSearch(int A[],int target)
	{
		int min=0,max=A.length-1,floor=-1,mid;
		while(min<=max)
		{
			mid = (min+max)/2;
			if(A[mid]==target)
			{
				floor = A[mid];
				break;
			}
			else if(A[mid]>target)
			{
				max = mid-1;
			}
			else if(A[mid]<target)
			{
				min = mid+1;
				floor = A[mid];
			}
		}
		return floor;
	}
	public static int ceilSearch(int A[],int target)
	{
		int min=0,max=A.length-1,ceil=-1,mid;
		while(min<=max)
		{
			mid = (min+max)/2;
			if(A[mid]==target)
			{
				ceil = A[mid];
				break;
			}
			else if(A[mid]>target)
			{
				max = mid-1;
				ceil = A[mid];
			}
			else if(A[mid]<target)
			{
				min = mid+1;
			}
		}
		return ceil;
	}
	public static void minimumAbsoluteDifference(int A[],int target)
	{
		int floor = floorSearch(A,target);
		int ceil = ceilSearch(A,target);
		int res;
		if(floor==-1)
			res = Math.abs(target-ceil);
		else if(ceil==-1)
			res = Math.abs(target-floor);
		else 
			res = (Math.abs(target-floor)<=Math.abs(target-ceil))?Math.abs(target-floor):Math.abs(target-ceil);
		System.out.println("Minimum absolute difference between "+target+" and array-element is: "+res);
	}
	public static int[] findRangeOfInfiniteArray(int A[],int target)
	{
		int range[] = new int[2];
		int start = 0;
		int end = 1;
		while(A[end]<target)
		{
			start = end;
			end = end*2;
		}
		range[0] = start;
		range[1] = end;
		return range;
	}
	public static void binarySearchOfRange(int A[],int target,int start,int end)
	{
		int pos=0;
		while(start<=end)
		{
			int mid = (start+end)/2;
			if(A[mid]==target)
			{
				pos=mid;
				break;
			}
			else if(A[mid]>target)
				end = mid-1;
			else
				start = mid+1;
		}
		if(start<=end)
			System.out.println("Found at "+pos+"th Position");
		else
			System.out.println("Not found");
	}
}