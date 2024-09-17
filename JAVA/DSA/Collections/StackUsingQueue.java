import java.util.*;
public class StackUsingQueue 
{
    Queue<Integer>queue1 = new LinkedList<>();
    Queue<Integer>queue2 = new LinkedList<>();
    public void push(int val)
    {
        queue1.offer(val);
    }
    public int pop()
    {
        if(queue1.isEmpty())
        {
            System.out.println("Stack is Empty");
        }
        while(queue1.size()!=1)
        {
            queue2.offer(queue1.poll());
        }
        int val = queue1.poll();
        while(!queue2.isEmpty())
        {
            queue1.offer(queue2.poll());
        }
        return val;
    }
    public int peek()
    {
        if(queue1.isEmpty())
        {
            System.out.println("Stack is Empty");
        }
        while(queue1.size()!=1)
        {
            queue2.offer(queue1.poll());
        }
        int val = queue1.peek();
        queue2.offer(queue1.poll());
        while(!queue2.isEmpty())
        {
            queue1.offer(queue2.poll());
        }
        return val;
    }
    public static void main(String[] args) 
    {
        StackUsingQueue stack = new StackUsingQueue();
        stack.push(10);
        stack.push(20);
        stack.push(30);
        stack.push(60);
        stack.push(40);
        stack.push(100);
        System.out.println(stack.peek());
        System.out.println(stack.pop());
        System.out.println(stack.peek());
    }
}
