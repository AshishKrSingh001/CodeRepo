public class AddtionalSearchAlgorithms
{
	public static void outputInArray(int A[])
	{
		System.out.println("**********Output-Start***********\nArray elements are:");
		for(int i=0;i<A.length;i++)
		{
			System.out.print(i+"-"+A[i]+"\t");
		}
		System.out.println("\n**********Output-End***********");
	}
	public static void main(String[]args)
	{
		//int A[] = {2, 3, 5, 7, 11, 34, 45, 65, 77,84,89,99,102,154,169,258,236};
		int A[] = {2,4,6,8,10,12,14,16,18,20,22,24,26,28};
		outputInArray(A);

		// *************Jump-Search********************
		// System.out.println(jumpSearch(A,65)+"\t65");
		// System.out.println(jumpSearch(A,77)+"\t77");
		// System.out.println(jumpSearch(A,2)+"\t2");
		// System.out.println(jumpSearch(A,1)+"\t1");
		// System.out.println(jumpSearch(A,0)+"\t0");
		// System.out.println(jumpSearch(A,11)+"\t11");
		// System.out.println(jumpSearch(A,22)+"\t22");
		// System.out.println(jumpSearch(A,34)+"\t34");

		// ****************Ternary-Search******************
		// System.out.println(ternarySearch(A,77)+"\t77");
		// System.out.println(ternarySearch(A,2)+"\t2");
		// System.out.println(ternarySearch(A,65)+"\t65");
		// System.out.println(ternarySearch(A,1)+"\t1");
		// System.out.println(ternarySearch(A,0)+"\t0");
		// System.out.println(ternarySearch(A,11)+"\t11");
		// System.out.println(ternarySearch(A,22)+"\t22");
		// System.out.println(ternarySearch(A,34)+"\t34");

		// ***************Exponential-Search*****************
		int c[] = {5};
		// System.out.println(exponentialSearch(c,77)+"\t77");
		// System.out.println(exponentialSearch(c,5)+"\t5");
		// System.out.println(exponentialSearch(A,65)+"\t65");
		// System.out.println(exponentialSearch(A,1)+"\t1");
		// System.out.println(exponentialSearch(A,0)+"\t0");
		// System.out.println(exponentialSearch(A,11)+"\t11");
		// System.out.println(exponentialSearch(A,236)+"\t236");
		// System.out.println(exponentialSearch(A,256)+"\t256");

		System.out.println(interpolationSearch(c,77)+"\t77");
		System.out.println(interpolationSearch(c,5)+"\t5");
		System.out.println(interpolationSearch(A,28)+"\t28");
		System.out.println(interpolationSearch(A,1)+"\t1");
		System.out.println(interpolationSearch(A,0)+"\t0");
		System.out.println(interpolationSearch(A,30)+"\t30");
		System.out.println(interpolationSearch(A,22)+"\t22");
		System.out.println(interpolationSearch(A,23)+"\t23");
	}
	public static int interpolationSearch(int A[], int target)
	{
		int start = 0;
		int end = A.length - 1;
		while(start <= end && A[start] <= target && target <= A[end])
		{
			int pos;
			if((A[end] - A[start]) == 0)
				pos = start;
			else
				pos = start + (target - A[start]) * (end - start) / (A[end] - A[start]);

			if(A[pos] == target)
				return pos;
			else if(A[pos] < target)
				start = pos + 1;
			else
				end = pos - 1;
		}
		return -1;
	}
	public static int exponentialSearch(int A[], int target)
	{
		if(A.length==1)
		{
			return(A[0] == target)?0:-1;
		}
		int end = 1;
		while(end < A.length && A[end] <= target)
		{
			end = end*2;
		}
		int max = Math.min(A.length-1,end);
		return binarySearch(A, target, end/2, max);
	}
	public static int binarySearch(int A[], int target, int start, int end)
	{
		while(start<=end)
		{
			int pos = start + (end - start) / 2;

			if(A[pos] == target)
				return pos;
			else if(A[pos] < target)
				start = pos + 1;
			else
				end = pos - 1;
		}
		return -1;
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
	public static int jumpSearch(int A[], int target)
	{
		int n = A.length; // length of the array 
		int blockSize = (int)Math.sqrt(n); // block size is sqrt(n) 
		int startIndex = 0; // starting of range
		int endIndex = blockSize; // ending of range
		
		// this condition is to check skip the un-potential block 
		// if we exceed A.length then loop will terminate and end will be in A.length position
		// if endIndex <= target loop will terminate and end will be at target
		while(endIndex < n && A[endIndex] <= target) 
		{
			startIndex = endIndex;
			endIndex += blockSize;
			
			if(endIndex>n)
				endIndex = n;
			
		}
		// performing linear search on potential block
		for(int i=startIndex;i<endIndex;i++)
		{
			if(A[i] == target)
				return i;
		}
		return -1;
	}
}
