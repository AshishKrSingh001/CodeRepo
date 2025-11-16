public class LC268_MissingNumber 
{
    public static void main(String[] args) 
    {
        System.out.println(sumOfNNumber(10));
    }
    public static int missingNumber(int[] nums) 
    {
        int max = Integer.MIN_VALUE;
        for(int i=0;i<nums.length;i++)
        {
            if(max<nums[i])
                max = nums[i];
        }
        int totalSum = sumOfNNumber(max);
        boolean zeroCount = false;
        for(int i=0;i<nums.length;i++)
        {
            if(nums[i]==0)
                zeroCount = true;
            totalSum -= nums[i];
        }
        if(totalSum==0)
        {
            if(zeroCount)
                return max+1;
            return 0;
        }
        return totalSum;
    }
    public static int sumOfNNumber(int n)
    {
        return n*(n+1)/2;
    }
}   
