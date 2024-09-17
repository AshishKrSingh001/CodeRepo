import java.util.*;
public class GFGAggressiveCows 
{
	public static void main(String[]args)
	{
		int []A = {1,2,4,8,9};
		int k=3;
		int n=5;
		System.out.println(solve(5,3,A));
	}
    public static int solve(int n, int k, int[] A) 
	{
		if(A.length<k)
			return -1;
		else
		{
			Arrays.sort(A);
			int start = 1;
			int end = A[A.length-1] - A[0];
			int res = start;
			while(start<=end)
			{
				int mid = (start+end)/2;
				if(isCowPlaced(A,k,mid))
				{
					res = mid;
					start = mid + 1;
				}
				else
					end = mid - 1;
			}
			return res;
		}
	}
	public static boolean isCowPlaced(int A[], int k, int minDistance)
	{
		int lastCowDistance=A[0];
		int cowPlaced = 1;
		for(int i=1;i<A.length;i++)
		{
			if(A[i] - lastCowDistance >= minDistance)
			{
				lastCowDistance = A[i];
				cowPlaced++;
			}
			if(cowPlaced>=k)
			{
				return true;
			}
		}
		return false;
	}
}