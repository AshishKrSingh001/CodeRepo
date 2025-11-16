class CircularQueue
{
    private int queue[], front, rear;
    public CircularQueue()
    {
        queue = new int[10];
        front = -1;
        rear = -1;
    }
    public CircularQueue(int size)
    {
        queue = new int[size];
        front = -1;
        rear = -1;
    }
    public boolean isEmpty()
    {
        return(rear==-1)?true:false;
    }
    public boolean isFull()
    {
        return((rear==queue.length-1 && front==0) || (front-rear==1))?true:false;
    }
    public boolean enqueue(int value)
    {
        if(isFull())
        {
            System.out.println("Queue is full");
            return false;
        }
        else if(isEmpty())
            front++;
        else if(front!=0 && rear==queue.length-1)
            rear = -1;
        queue[++rear] = value;
        return true;
    }
    public int dequeue()
    {
        if(isEmpty())
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
        else if(front==queue.length-1)
        {
            front=0;
            return queue[front];
        }
        return queue[front++];
    }
    public int peek()
    {
        if(isEmpty())
        {
            System.out.println("Queue is empty");
            return -1;
        }
        return queue[front];
    }
    public void printQueue()
    {
        if(isEmpty())
        {
            System.out.println("Queue is empty");
            return;
        }
        System.out.println("*************************************\nQueue");
        if(front<=rear)
        {
            for(int i=front;i<=rear;i++)
            {
                System.out.print(queue[i]+"\t");
            }
        }
        else
        {
            for(int i=front;i<=queue.length-1;i++)
            {
                System.out.print(queue[i]+"\t");
            }
            for(int i=0;i<=rear;i++)
            {
                System.out.print(queue[i]+"\t");
            }
        }
        System.out.println("\n*************************************");
    }

}
public class CircularCircularQueueWithArray  
{
    public static void main(String[] args) 
    {
        System.out.println("Queue Implementation");
        CircularQueue q = new CircularQueue(5);
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
        System.out.println(q.enqueue(20));
        System.out.println(q.enqueue(30));
        System.out.println(q.enqueue(40));
        System.out.println(q.enqueue(50));
        q.printQueue();
        System.out.println(q.dequeue());q.printQueue();
        System.out.println(q.enqueue(5000));
        q.printQueue();
    }    
}

