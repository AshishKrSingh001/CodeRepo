
import java.util.Stack;

public class NextGreaterElementInRotatedArray
{
    public static void printArray(long A[])
    {
        System.out.println("Array Element: ");
        for(int i=0;i<A.length;i++)
        {
            System.out.print(A[i]);
            if(i!=A.length-1)
            {
                System.out.print(", ");
            }
        }
        System.out.println("");
    }
    public static long[]nextGreaterElement(long[]nums)
    {
        Stack<Long>stack = new Stack<>();
        int N = nums.length;
        long[]res = new long[N];
        for(int i=2*N-1;i>=0;i--)
        {
            if(stack.isEmpty())
            {
                stack.push(nums[i%N]);
                if(i<N)
                    res[i] = -1;
            }
            else
            {
                while(!stack.isEmpty() && stack.peek()<=nums[i%N])
                {
                    stack.pop();
                }
                if(i<N)
                    res[i] = (stack.isEmpty())?-1:stack.peek();
                stack.push(nums[i%N]);
                // System.out.println(stack);
            }
        }
        return res;
    }
    public static void main(String[] args) 
    {
        long[]A = {2, 4, 1, 7, 9, 20, 16};
        printArray(A);
        long[]B = nextGreaterElement(A);
        printArray(B);
    }
}

