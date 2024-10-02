// Online Java Compiler
// Use this editor to write, compile and run your Java code online
import java.util.*;
public class FindAllSubsequencesWithSumEqualToK  {
    public static void main(String[] args) {
        System.out.println("Try programiz.pro");
        int a[] = {17, 18, 6, 11, 2, 4};
        List<Integer>list = new ArrayList<>();
        subsequencesWithSumEqualK(a,0,a.length,list,6);
    }
    public static void subsequencesWithSumEqualK(int nums[], int index, int n, List<Integer>list, int k)
    {
        if(index == n)
        {
            int sum = 0;
            for(int i:list)
            {
                sum += i;
            }
            if(sum==k)
            {
                System.out.println(list);
            }
            //  System.out.println(list);
            return;
        }
        list.add(nums[index]);
        subsequencesWithSumEqualK(nums, index+1, n, list, k);
        list.remove(list.size()-1);
        subsequencesWithSumEqualK(nums, index+1, n, list, k);
    }
}
