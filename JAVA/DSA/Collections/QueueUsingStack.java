import java.util.Stack;

public class QueueUsingStack 
{
    Stack<Integer>stack1;
    Stack<Integer>stack2;
    public QueueUsingStack()
    {
        stack1 = new Stack<>();
        stack2 = new Stack<>();
    }
    public void enqueue(int val)
    {
        stack1.push(val);
    }
    public int dequeue()
    {
        if(stack1.isEmpty())
        {
            System.out.println("Stack is Empty");
        }
        while(!stack1.isEmpty())
        {
            stack2.push(stack1.pop());
        }
        int val = stack2.pop();
        while(!stack2.isEmpty())
        {
            stack1.push(stack2.pop());
        }
        return val;
    }
    public int peek()
    {
        if(stack1.isEmpty())
        {
            System.out.println("Stack is Empty");
        }
        while(!stack1.isEmpty())
        {
            stack2.push(stack1.pop());
        }
        int val = stack2.peek();
        while(!stack2.isEmpty())
        {
            stack1.push(stack2.pop());
        }
        return val;
    }
    public static void main(String[] args) 
    {
       QueueUsingStack q = new QueueUsingStack();
       q.enqueue(10);
       q.enqueue(100);
       q.enqueue(60);
       q.enqueue(30);
       q.enqueue(40);
       q.enqueue(20);
       System.out.println(q.peek());
       System.out.println(q.dequeue());
       System.out.println(q.peek());
       
    }
}
