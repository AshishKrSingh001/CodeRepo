public class LC20_ValidParentheses 
{
    public static boolean isValid(String s) 
    {
        char stack[] = new char[s.length()];
        int top = -1;
        for(int i=0;i<s.length();i++)
        {
            if(top == -1)
                stack[++top] = s.charAt(i);
            else if((stack[top] == '[' && s.charAt(i) == ']') || (stack[top] == '{' && s.charAt(i) == '}') || (stack[top] == '(' && s.charAt(i) == ')'))
                top--;
            else
                stack[++top] = s.charAt(i);
        }
        return(top == -1);
    }
    public static void main(String[] args) 
    {
        System.out.println(isValid("([])"));
        System.out.println(isValid("()"));
        System.out.println(isValid("(]"));
        System.out.println(isValid("()[]{}"));
    }
}


