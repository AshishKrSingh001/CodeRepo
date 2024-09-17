public class LC2064_MinimizedMaximumOfProductsDistributedToAnyStore
{
	public static void main(String[]args)
	{
		int A[] = {15,10,10};
		int n = 7;
		System.out.println(minimizedMaximum(n,A));
		System.out.println("7");
	}
	public static int minimizedMaximum(int n, int[] quantities) 
    {
        int start = 1;
		int end = Integer.MIN_VALUE;
		
		for(int i=0;i<quantities.length;i++)
		{
			if(end<quantities[i])
				end = quantities[i];
		}
		
		int res = start;
		while(start<=end)
		{
			int mid = (start+end)/2;
			if(isSmallerPossible(quantities,n,mid))
			{
				res = mid;
				end = mid - 1;
			}
			else
				start = mid + 1;
				
		}
		return res;
    }
	
	public static boolean isSmallerPossible(int[] quantities,int n,int minimumDistribution)
	{
		int sum = 0;
		for(int i=0;i<quantities.length;i++)
		{
			sum = sum + quantities[i]/minimumDistribution;
			if(quantities[i] % minimumDistribution != 0)
				sum += 1;
			if(sum>n)
				return false;
		}
		return true;
	}
}
