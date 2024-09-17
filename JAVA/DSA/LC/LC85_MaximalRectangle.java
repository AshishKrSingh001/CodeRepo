import java.util.Stack;
public class LC85_MaximalRectangle 
{
    public static void main(String[] args) 
    {
        char matrix[][] = {
                            {'1','0','1','0','0'},
                            {'1','0','1','1','1'},
                            {'1','1','1','1','1'},
                            {'1','0','0','1','0'}
                        };
        System.out.println(maximalRectangle(matrix));
    }
    public static int maximalRectangle(char[][] matrix) 
    {
        int row = matrix.length;
        int col = matrix[0].length;
        int A[] = new int[col];
        int max = Integer.MIN_VALUE;
        for(int i=0;i<col;i++)
        {
            A[i] = (matrix[0][i]=='1')?1:0;
        }
        int val = largestRectangleArea(A);
        if(val>max)
            max = val;
        for(int i=1;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                int value = (matrix[i][j]=='1')?1:0;
                if(value==1)
                {
                    A[j] += 1;
                }
                else
                {
                    A[j]=0;
                }
            }
            int currentElement = largestRectangleArea(A);
            if(currentElement>max)
                max = currentElement;
        }
        return max;
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
