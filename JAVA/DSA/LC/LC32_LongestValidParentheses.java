import java.util.Stack;
public class LC32_LongestValidParentheses 
{
    public static void main(String[] args) 
    {
        System.out.println(longestValidParentheses(""));
    }
    public static int longestValidParentheses(String s) 
    {
        Stack<Integer>stack = new Stack<>();
        for(int i=0;i<s.length();i++)
        {
            char ch = s.charAt(i);
            if(stack.isEmpty())
                stack.push(i);
            else if(ch==')' && s.charAt(stack.peek())=='(')
                stack.pop();
            else if(ch=='(' || ch==')')
                stack.push(i);
        }
        stack.push(s.length());
        int maxCount=0,lowerBound,upperBound;
        for(int i=stack.size()-1;i>0;i--)
        {
            upperBound = stack.pop();
            lowerBound = stack.peek();
            int count=upperBound-lowerBound-1;
            if(maxCount<count)
                maxCount = count;   
        }
        upperBound = stack.pop();
        lowerBound = -1;
        int count=upperBound-lowerBound-1;
        if(maxCount<count)
            maxCount = count;  
        return maxCount;
    }
}
