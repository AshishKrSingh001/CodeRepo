
import java.util.ArrayList;
import java.util.List;

public class LC448_FindAllNumbersDisappearedInArray 
{
    public static void outputInArray(int A[],String message)
	{
		System.out.println("**********Output-Start***********\n"+message+" elements are:");
        System.out.print("->\t");
		for(int i=0;i<A.length;i++)
		{
			System.out.print(A[i]+"\t");
		}
		System.out.println("\n**********Output-End***********\n");
	}
    public static void main(String[] args) 
    {
        int A[] = {1,1};
        outputInArray(A, "Array");

        for (int i : findDisappearedNumbers(A)) {
            System.out.println(i);
        }
    }
    public static List<Integer> findDisappearedNumbers(int[] nums) 
    {
        List<Integer> res = new ArrayList();
        int countArray[] = new int[nums.length+1]; // declare the counting val will will count the frequency of element in array

        for(int i=0;i<nums.length;i++)
            countArray[nums[i]]++; // counting frequency
        
        for(int i=1;i<countArray.length;i++)
        {
            if(countArray[i]==0)
                res.add(i);
        }
        
        return res; 
    }
}
