import java.util.Stack;
public class LC84_LargestRectangleHistogram 
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
        int []A = {2,4};
        // int []A = {2,1,5,6,2,3};

        System.out.println(largestRectangleArea(A));
    }
    public static int largestRectangleArea(int[] heights) 
    {
        int ns[] = nextSmallerElement(heights);
        int ps[] = prevSmallerElement(heights);
        int n = heights.length;
        int max = 0;
        for(int i=0;i<n;i++)
        {
            int area = (ns[i] - ps[i] - 1)*heights[i];
            if(area>max)
                max = area;
        }
        return max;
    }
    public static int[] nextSmallerElement(int []heights)
    {
        Stack<Integer>stack = new Stack<>();
        int n = heights.length;
        int res[] = new int[n];
        
        for(int i=n-1;i>=0;i--)
        {
            while(!stack.isEmpty() && heights[stack.peek()]>=heights[i])
                stack.pop();
            if(stack.isEmpty())
            {
                stack.push(i);
                res[i] = n;
            }
            else
            {
                res[i] = stack.peek();
                stack.push(i);
            }
        }
        return res;
    }
    public static int[] prevSmallerElement(int []heights)
    {
        Stack<Integer>stack = new Stack<>();
        int n = heights.length;
        int res[] = new int[n];
        
        for(int i=0;i<n;i++)
        {
            while(!stack.isEmpty() && heights[stack.peek()]>=heights[i])
                stack.pop();
            if(stack.isEmpty())
            {
                stack.push(i);
                res[i] = -1;
            }
            else
            {
                res[i] = stack.peek();
                stack.push(i);
            }
        }
        return res;
    }
    

}
