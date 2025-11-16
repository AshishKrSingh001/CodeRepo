public class LC875_KokoEatingBananas
{
	public static void main(String[]args)
	{
		int A[] = {3,6,7,11};
		int h = 8;
		System.out.println(minEatingSpeed(A,h));
	}
	public static int minEatingSpeed(int[] piles, int hours) 
	{
        int start = 1;
		int end = Integer.MIN_VALUE;
		for(int i=0;i<piles.length;i++)
		{
			if(piles[i]>end)
				end = piles[i];
		}
		int res = 1;
		while(start<=end)
		{
			int mid = (start+end)/2;
			if(isEatingPossible(piles,hours,mid))
			{
				res = mid;
				end = mid - 1;
			}
			else
				start = mid + 1;
		}
		return res;
    }
	public static boolean isEatingPossible(int[] piles, int hours,int bananaPerHours)
	{
		int h = 0;
		for(int i=0;i<piles.length;i++)
		{
			h += Math.ceil((double)piles[i]/bananaPerHours);
			if(h>hours)
				return false;
		}
		return true;
	}
}
