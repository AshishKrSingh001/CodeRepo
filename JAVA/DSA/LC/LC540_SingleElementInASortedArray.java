public class LC540_SingleElementInASortedArray
{
	public static void main(String[]args)
	{
		int nums[] = {1,1,2,2,3,3,4,8,8};
		System.out.println(singleNonDuplicate(nums));
		//System.out.println(4^1);
	}
	public static int singleNonDuplicate(int[] nums) 
    {
        int start = 0;
		int end = nums.length-2;
		
		while(start<=end)
		{
			int mid = (start+end)/2;
            if(nums[mid]==nums[mid+1])
			{
				if(mid%2==0)
					start = mid+1;
				else
					end = mid-1;
			}
            else
            {
				if(mid%2!=0)
					start = mid+1;
				else
					end = mid-1;
			}
		}
		return nums[start];
    }
}