package dsa.array;

import java.util.*;

public class array01_ArrayFunctions
{
	public static void main(String[]s)
	{
		//int A[] = {0,1,2,2,3,0,4,2};
		int A[] = {1,2};
		int B[] = {3,4};
		outputInArray(A);
		outputInArray(B);
		A = mergeSortedArray(A,B);
		outputInArray(A);
		
		double median=0;
        A = mergeSortedArray(A,B);
        
        if(A.length % 2 == 0)
            median = (A[(A.length/2)-1]+A[A.length/2])/2;
        else
            median = (A[(A.length/2)-1]);
        System.out.println(median);
	}
	public static int removeElement(int[] A, int val) 
    {
        int n = A.length-1;
		for(int i=0;i<=n;i++)
		{
			if(A[i] == val)
			{
				if(A[n]==val)
					n--;
				int temp = A[i];
				A[i] = A[n];
				A[n] = temp;
				n--;
			}
		}
		return n+1;
    }
	public void inputInArray(int A[])
	{
		Scanner sc = new Scanner(System.in);
		
		System.out.println("**********Input**********\nEnter "+A.length+" numbers in an array: ");
		for(int i=0;i<A.length;i++)
		{
			A[i] = sc.nextInt();
		}
		System.out.println("**********Input-End***********");
	}
	
	public static void outputInArray(int A[])
	{
		System.out.println("**********Output-Start***********\nArray elements are:");
		for(int i=0;i<A.length;i++)
		{
			System.out.print(A[i]+"\t");
		}
		System.out.println("\n**********Output-End***********");
	}
	public static int[] mergeSortedArray(int nums1[],int nums2[])
	{
		int i=0,j=0,k=0;
        int A[] = new int[nums1.length+nums2.length];
        while(i<nums1.length && j<nums2.length)
        {
            if(nums1[i]<=nums2[j])
                A[k++] =nums1[i++];
            else
                A[k++] =nums2[j++];
        }
        if(i!=nums1.length)
        {
            while(i<nums1.length)
                A[k++] =nums1[i++];
        }
        else if(j!=nums2.length)
        {
            while(j<nums2.length)
                A[k++] =nums2[j++];
        }
		return A;
	}

	public int[] removeEvenInteger(int[]A)
	{
		System.out.println("**********Processing***********");
		int i,oddCount = 0;
		for(i=0;i<A.length;i++)
		{
			if(A[i] % 2 != 0)
			{
				oddCount++;
			}
		}
		int resultArray[] = new int[oddCount]; 
		int idx = 0;
		for(i=0;i<A.length;i++)
		{
			if(A[i] % 2 != 0)
			{
				resultArray[idx++] = A[i];
			}
		}
		return resultArray;
	}
	public int[] reverseOfArray(int A[])
	{
		int B[] = new int[A.length];
		int i,j;
		for(i=0,j=A.length-1;i<A.length;i++,j--)
		{
			B[i] = A[j];
		}
		return B;
	}
	public int findMin(int A[])
	{
		int min = A[0];
		for(int i=1;i<A.length;i++)
		{
			if(A[i]<min)
			{
				min = A[i];
			}
		}
		return min;
	}
	public int findMax(int A[])
	{
		int max = A[0];
		for(int i=1;i<A.length;i++)
		{
			if(A[i]>max)
			{
				max = A[i];
			}
		}
		return max;
	}
	public int findSecondMax(int A[])
	{
		int max = 0;
		int smax = 0;
		for(int i=1;i<A.length;i++)
		{
			if(A[i]>max)
			{
				smax = max;
				max = A[i];
			}
			else if(A[i]<max && A[i]>smax)
			{
				smax = A[i];
			}
		}
		return smax;
	}
	public void moveZeroToEnd(int []A)
	{
		int j=0;
		for(int i=0;i<A.length;i++)
		{
			if(A[i]!=0 && A[j]==0)
			{
				int temp = A[i];
				A[i] = A[j];
				A[j] = temp;
			}
			if(A[j]!=0)
			{
				j++;
			}
		}
	}
	public int[] resizeArray(int []A,int n)
	{
		int []tempArr = new int[n];
		for(int i=0;i<A.length;i++)
		{
			tempArr[i] = A[i];
		}
		return tempArr;
	}
	public int findMissingNumber(int A[])
	{
		int min=A[0],max=A[0];
		
		for(int i=1;i<A.length;i++)
		{
			if(A[i]<min)
			{
				min = A[i];
			}
			if(A[i]>max)
			{
				max = A[i];
			}
		}
		
		int sum = ((A.length+1)*(min+max))/2;
		for(int num:A)
		{
			sum = sum - num;
		}
		
		return sum;
	}
	public int[] insertAtPosition(int A[],int pos,int element)
	{
		if(pos<0 || pos>A.length)
		{
			System.out.println("Invalid Position");
			return A;
		}
		int myArr[] = new int[A.length+1];
		int i;
		for(i=0;i<pos;i++)
		{
			myArr[i] = A[i];
		}
		myArr[pos] = element;
		for(i=pos;i<A.length;i++)
		{
			myArr[++pos] = A[i];
		}
		return myArr;
	}
	public int[] deleteAtPosition(int A[],int pos)
	{
		if(pos<0 || pos>A.length-1)
		{
			System.out.println("Invalid Position");
			return A;
		}
		int myArr[] = new int[A.length-1];
		int i;
		for(i=0;i<pos;i++)
		{
			myArr[i] = A[i];
		}
		for(i=pos+1;i<A.length;i++)
		{
			myArr[pos] = A[i];pos++;
		}
		return myArr;
	}
	
	
}