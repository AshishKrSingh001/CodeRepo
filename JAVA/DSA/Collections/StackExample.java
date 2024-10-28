import java.util.Stack;

public class StackExample
{
    public static void displayStack(Stack<Integer>s)
    {
        System.out.println("Stack Element is: ");
        for(int i=0;i<s.size();i++)
        {
           System.out.print(s.get(i));
           if(i!=s.size()-1)
           {
                System.out.print(", ");
           }
        }
        System.out.println("\n******************");
    }
    public static void main(String[] args) 
    {
        Stack<Integer> s1 = new Stack<>();
        s1.push(1);s1.push(2);s1.push(3);
        Stack<Integer> s2 = new Stack<>();
        s2.push(11);s2.push(22);s2.push(33);
        displayStack(s1);
        displayStack(s2);
        
        while(!s1.isEmpty())
        {
            int val = s1.pop();
            int t1 = s1.size();
            while(!s2.isEmpty() && s2.peek()>val)
            {
                s1.push(s2.pop());
            }
            s2.push(val);
            displayStack(s1);
            displayStack(s2);
            while(s1.size() != t1)
            {
                s2.push(s1.pop());
            }
        }
        displayStack(s1);
        displayStack(s2);
    }
}