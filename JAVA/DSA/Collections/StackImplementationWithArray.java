// package Stack;

public class StackImplementationWithArray 
{
    int stack[],top;
    public StackImplementationWithArray(int size)
    {
        stack = new int[size];
        top = -1;
    }
    public boolean isEmpty()
    {
        return(top==-1)?true:false;
    }
    public boolean isFull()
    {
        return(top==stack.length-1)?true:false;
    }
    public void push(int val)
    {
        if(!isFull())
        {
            stack[++top] = val;
            return;
        }
        System.err.println("Stack is full");
    }
    public int pop()
    {
        if(!isEmpty())
            return stack[top--];
        System.err.println("Stack is Empty");
        return -1;
    }
    public int peek()
    {
        if(!isEmpty())
            return stack[top];
        System.err.println("Stack is Empty");
        return Integer.MIN_VALUE;
    }
    public void printStack()
    {
        if(isEmpty())
        {
            System.err.println("Stack is Empty");
            return;
        }
        System.out.println("Printing Stack");
        for(int i=0;i<=top;i++)
        {
            System.out.print(stack[i]+"\t");
        }
        System.out.println("");
    }
    public static void main(String[] args) 
    {
        System.out.println("Hello");
        StackImplementationWithArray s = new StackImplementationWithArray(5);
        s.printStack();
        s.push(10);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(20);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(30);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(50);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(70);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(80);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(40);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(50);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(60);s.printStack();System.err.println(s.peek());s.printStack();
        s.push(50);s.printStack();System.err.println(s.peek());s.printStack();
    }
}
