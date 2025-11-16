
import java.util.Stack;

public class LC503_NextGreaterElementII 
{
    public static void outputInArray(int A[])
	{
		System.out.println("**********Output-Start***********\nArray elements are:");
		for(int i=0;i<A.length;i++)
		{
			System.out.print(A[i]+"\t");
		}
		System.out.println("\n**********Output-End***********");
	}
    public static void main(String[] args) 
    {
        int []A = {5,1,2,1};
        outputInArray(A);
        A = nextGreaterElements(A);
        outputInArray(A);
    }
    public static int[] nextGreaterElements(int[] nums) 
    {
        int n = nums.length;
        Stack<Integer>stack = new Stack<>();
        // int[]res = new int[n];
        for(int i=2*n-1;i>=0;i--)
        {
            while(!stack.isEmpty() && stack.peek()<=nums[i%n])
                stack.pop();
            if(i<n)
            {
                int val;
                if(stack.isEmpty())
                {
                    val = nums[i];
                    nums[i] = -1;
                    stack.push(val);
                }
                else
                {
                    val = nums[i];
                    nums[i] = stack.peek();
                    stack.push(val);
                }
            }
            else
            stack.push(nums[i%n]);
        }
        return nums;
    }
}
