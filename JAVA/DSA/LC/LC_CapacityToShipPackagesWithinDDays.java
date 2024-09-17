public class  LC_CapacityToShipPackagesWithinDDays
{
	public int shipWithinDays(int[] weights, int days) 
    {
        int start = Integer.MIN_VALUE; // for max element of array
		int end = 0; // for sum of all element of array
		
		for(int i=0;i<weights.length;i++)
		{
			if(weights[i] > start)
				start = weights[i];
			end += weights[i];
		}
		int res = 0;
		while(start<=end)
		{
			int mid = (start+end)/2;
			if(isAllocationOfDaysPossible(weights,days,mid))
			{
				res = mid;
				end = mid - 1;
			}
			else
				start = mid + 1;
		}
		return res;
    }
	boolean isAllocationOfDaysPossible(int[] weights, int days, int maxWeights)
	{
		int currentDays = 1; // for checking if days exceeds 
		int weightForSingleDay=0; // for allocate minimum weight of single day
		
		for(int i=0;i<weights.length;i++)
		{
			weightForSingleDay += weights[i]; 
			if(weightForSingleDay > maxWeights)
			{	
				currentDays += 1;
				weightForSingleDay = weights[i]; 
			}
			if(currentDays > days)
				return false;
		}
		return true;
	}
}