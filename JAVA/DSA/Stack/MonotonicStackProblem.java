import java.util.*;
public class MonotonicStackProblem
{
    List<Integer>list;
    Stack<Integer> stack;
    public MonotonicStackProblem()
    {
        list = new ArrayList<>();
        stack = new Stack<>();
    }
    public int next(int val)
    {
        list.add(val);
        if(stack.isEmpty())
        {
            stack.push(list.size()-1);
        }
        else
        {
            while(!stack.isEmpty() && list.get(stack.peek())<=val)
            {
                stack.pop();
            }
            if(stack.size()>0)
            {
                stack.push(list.size()-1);
            }
        }
        int ind1 = (stack.size()>0)?stack.get(stack.size()-1):0;
        int ind2 = (stack.size()-1>0)?stack.get(stack.size()-2):-1;
        return ind1 - ind2;
    }
    public static void main(String[] args) 
    {
        MonotonicStackProblem m = new MonotonicStackProblem();
        System.out.println(m.next(100)+"->100");
        System.out.println(m.next(80)+"->80");
        System.out.println(m.next(60)+"->60");
        System.out.println(m.next(70)+"->70");
        System.out.println(m.next(60)+"->60");
        System.out.println(m.next(75)+"->75");
        System.out.println(m.next(85)+"->85");
    }
}
