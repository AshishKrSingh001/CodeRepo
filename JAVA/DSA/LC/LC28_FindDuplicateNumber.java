
import java.util.ArrayList;
import java.util.List;

public class LC28_FindDuplicateNumber
{
    public int findDuplicate(int[] nums) 
    {
        int countArray[] = new int[nums.length]; 
        // declare the counting val will will count the frequency of element in array

        for(int i=0;i<nums.length;i++)
            countArray[nums[i]]++; // counting frequency

        for(int i=0;i<countArray.length;i++)
        {
            while(countArray[i]>1)
            {
                return i;
            }
        }
        return 0;
    }
    public List<Integer> findDuplicates(int[] nums) 
    {
        List<Integer> list = new ArrayList<>();
        int countArray[] = new int[nums.length]; 
        // declare the counting val will will count the frequency of element in array

        for(int i=0;i<nums.length;i++)
            countArray[nums[i]] += 1; // counting frequency

        for(int i=0;i<countArray.length;i++)
        {
            if(countArray[i]==2)
            {
                list.add(i);
            }
        }
        return list;
    }
}
