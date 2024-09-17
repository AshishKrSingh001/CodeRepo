public class LC1283_FindSmallestDivisorGivenThreshold
{
	public static void main(String[]args)
	{
		int A[] = {1,2,5,9};
		int threshold = 6;
		System.out.println(smallestDivisor(A,threshold));
		System.out.println("5");
	}
	public static int smallestDivisor(int[] A, int threshold) 
    {
        int start = 1;
		int end = Integer.MIN_VALUE;
		
		for(int i=0;i<A.length;i++)
		{
			if(end<A[i])
				end = A[i];
		}
		
		int res = start;
		while(start<=end)
		{
			int mid = (start+end)/2;
			if(isSmallerPossible(A,threshold,mid))
			{
				res = mid;
				end = mid - 1;
			}
			else
				start = mid + 1;
				
		}
		return res;
    }
	public static boolean isSmallerPossible(int[] A, int threshold, int divisor)
	{
		int sum = 0;
		for(int i=0;i<A.length;i++)
		{
			sum = sum + A[i]/divisor;
			if(A[i] % divisor != 0)
				sum += 1;
			if(sum>threshold)
				return false;
		}
		return true;
	}
}
