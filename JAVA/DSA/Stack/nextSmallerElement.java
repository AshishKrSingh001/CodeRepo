
import java.util.Stack;

public class nextSmallerElement
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
    public static long[]nextSmallerElement(long[]nums)
    {
        Stack<Integer>stack = new Stack<>();
        int N = nums.length;
        long[]res = new long[N];
        for(int i=N-1;i>=0;i--)
        {
            if(stack.isEmpty())
            {
                stack.push(i);
                res[i] = -1;
            }
            else
            {
                while(!stack.isEmpty() && nums[stack.peek()]>nums[i])
                {
                    stack.pop();
                }
                res[i] = (stack.isEmpty())?-1:nums[stack.peek()];
                stack.push(i);
                // System.out.println(stack);
            }
        }
        return res;
    }
    public static void main(String[] args) 
    {
        long[]A = {3, 8, 5, 2, 25};
        printArray(A);
        long[]B = nextSmallerElement(A);
        printArray(B);
    }
}

