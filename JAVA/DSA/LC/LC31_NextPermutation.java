public class LC31_NextPermutation 
{
    public static void main(String[] args) 
    {
        int A[] = {1,3,5,6};
        outputInArray(A);
        System.out.println(searchInsert(A, 0));
        System.out.println(searchInsert(A, 1));
        System.out.println(searchInsert(A, 6));
        System.out.println(searchInsert(A, 8));
        System.out.println(searchInsert(A, 4));
        System.out.println(searchInsert(A, 5));
    }
    public static int searchInsert(int[] nums, int target) 
    {
        int res = 100;
        int start = 0;
        int end = nums.length-1;
        while(start<=end)
        {
            int mid = start + (end - start)/2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid]<target)
            {
                res = mid;
                start = mid + 1;
            }
            else
            {
                res = mid;
                end = mid -1;
            }
        }
        return res;
    }
    public static int[] nextPermutation(int[] nums) 
    {
       for(int i=nums.length-2;i>=0;i--)
       {
            for(int j=nums.length-1;j>i;j--)
            {
                if(nums[i]<nums[j])
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    outputInArray(nums);
                }
            }
       }
       return nums;
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
}
