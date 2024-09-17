import java.util.Stack;

public class StackExample
{
    public static void main(String[] args) 
    {
        Stack<Integer> stack = new Stack<>();
        stack.push(2);
        stack.push(20);
        stack.push(12);
        stack.push(15);
        stack.push(8);
        stack.push(7);
        stack.push(3);

        System.out.println(stack);
        System.out.println(stack.peek());
        System.out.println(stack.pop());
        System.out.println(stack.peek());
        System.out.println(stack);
    }
}