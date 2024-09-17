class QueueImplementation
{
    private int queue[], front, rear;
    public QueueImplementation()
    {
        queue = new int[10];
        front = -1;
        rear = -1;
    }
    public QueueImplementation(int size)
    {
        queue = new int[size];
        front = -1;
        rear = -1;
    }
    public boolean enqueue(int value)
    {
        if(rear==queue.length-1)
        {
            System.out.println("Queue is full");
            return false;
        }
        else if(front==-1 && rear==-1)
            front++;
        queue[++rear] = value;
        return true;
    }
    public int dequeue()
    {
        if(front==-1 && rear==-1)
        {
            System.out.println("Queue is empty");
            return -1;
        }
        else if(front==rear)
        {
            int val = queue[rear];
            front=-1;
            rear=-1;
            return val;
        }
        return queue[front++];
    }
    public int peek()
    {
        if(front==-1 && rear==-1)
        {
            System.out.println("Queue is empty");
            return -1;
        }
        return queue[front];
    }
    public void printQueue()
    {
        if(front==-1 && rear==-1)
        {
            System.out.println("Queue is empty");
            return;
        }
        for(int i=front;i<=rear;i++)
        {
            System.out.print(queue[i]+"\t");
        }
        System.out.println("");
    }

}
public class QueueImplementationWithArray 
{
    public static void main(String[] args) 
    {
        System.out.println("Queue Implementation");
        QueueImplementation q = new QueueImplementation(5);
        System.out.println(q.enqueue(10));
        System.out.println(q.peek());
        System.out.println(q.enqueue(20));
        System.out.println(q.enqueue(30));
        System.out.println(q.enqueue(40));
        System.out.println(q.enqueue(50));
        System.out.println(q.enqueue(50));
        q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.enqueue(50));
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
    }    
}
