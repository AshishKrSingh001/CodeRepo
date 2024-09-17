class dequeImpletation
{
    private int queue[], front, rear;
    public dequeImpletation()
    {
        queue = new int[10];
        front = -1;
        rear = -1;
    }
    public dequeImpletation(int size)
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
    public boolean enqueueRear(int value)
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
    public boolean enqueueFront(int value)
    {
        if(isFull())
        {
            System.out.println("Queue is full");
            return false;
        }
        else if(isEmpty())
            front++;
        else if((front>0 && front<rear)||(front-rear!=1 && front>rear))
        {
            queue[--front] = value;
        }
        else if(front==0 && rear!=queue.length-1)
        {
            front = queue.length-1;
            queue[front] = value;
        }
        return true;
    }
    public int dequeueRear()
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
        else if(rear==0)
        {
            rear = queue.length-1;
            return queue[rear];
        }
        return queue[rear--];
    }
    public int dequeueFront()
    {
        if(isEmpty())
        {
            System.out.println("Queue is empty");
            return -1;
        }
        else if(front==rear)
        {
            int val = queue[front];
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
    public int peekRear()
    {
        if(isEmpty())
        {
            System.out.println("Queue is empty");
            return -1;
        }
        return queue[rear];
    }
    public int peekFront()
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
public class DequeImplementationWIthArray  
{
    public static void main(String[] args) 
    {
        System.out.println("Queue Implementation");
        dequeImpletation q = new dequeImpletation(5);
        System.out.println(q.enqueueRear(10));
        
        System.out.println(q.enqueueRear(20));
        System.out.println(q.enqueueRear(30));
        System.out.println(q.enqueueRear(40));
        System.out.println(q.enqueueRear(50));
        System.out.println(q.enqueueRear(50));
        q.printQueue();
        System.out.println(q.peekFront());
        System.out.println(q.peekRear());
        // System.out.println(q.dequeueFront());q.printQueue();
        // System.out.println(q.enqueueRear(50));
        // System.out.println(q.dequeueFront());q.printQueue();
        // System.out.println(q.dequeueFront());q.printQueue();
        // System.out.println(q.dequeueFront());q.printQueue();
        // System.out.println(q.enqueueRear(20));
        // System.out.println(q.enqueueRear(30));
        // System.out.println(q.enqueueRear(40));
        // System.out.println(q.enqueueRear(50));
        // q.printQueue();
        // System.out.println(q.dequeueFront());q.printQueue();
        // System.out.println(q.enqueueRear(5000));
        // q.printQueue();
    }    
}


