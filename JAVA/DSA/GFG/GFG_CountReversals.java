public class GFG_CountReversals 
{
    public static int countRev (String s)
    {
        if(s.length() % 2 != 0)
            return -1;
        char stack[] = new char[s.length()];
        int top = -1;
        for(int i=0;i<s.length();i++)
        {
            if(top == -1)
                stack[++top] = s.charAt(i);
            else if(stack[top] == '{' && s.charAt(i) == '}')
                top--;
            else
                stack[++top] = s.charAt(i);
        }
        if(top == -1)
            return 0;
        int l=0,r=0;
        for(int i=0;i<=top;i++)
        {
            if(stack[i] == '{')
                l++;
            else if(stack[i] == '}')
                r++;
        }
        return (r%2 == 0)?(r/2 + l/2):(r/2+1 + l/2+1);
        
    }
    public static void main(String[] args) 
    {
        System.out.println(countRev("}}}}{{{{"));
        System.out.println(countRev("}{{}}{{{"));
        System.out.println(countRev("}}}}{{{{"));
    }    
}
