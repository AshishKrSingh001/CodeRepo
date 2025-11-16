public class LLIntroduction 
{
    Node<Integer>head;
    int size;

    public LLIntroduction() 
    {
        this.head = null;
        this.size = 0;
    }
    public int length()
    {
        return this.size;
    }
    public void updateNodeValue(int data, int pos)
    {
        if(pos<=0 || pos>size)
        {
            System.out.println("Invalid Position");
            return;
        }
        Node<Integer>temp = head;
        int counter=0;
        while(temp.next != null)
        {
            counter++;
            if(counter==pos)
            {
                break;
            }
            temp = temp.next;
        }
        temp.data = data;
        System.out.println("LinkedList is Updated");
    }
    public int searchNodeValue(int searchValue)
    {
        Node<Integer>temp = head;
        for(int i=1;i<=size;i++)
        {
            if(temp.data == searchValue)
            {
                return i;
            }
            temp = temp.next;
        }
        return 0;
    }
    public void deleteNodeAtHead()
    {
        if(head==null)
        {
            System.out.println("LinkedList is Empty");
            return;
        }
        Node<Integer>temp = head;
        head = head.next;
        temp.next = null;
        System.out.println("Deleted Successfully at tail");
        size--;
    }
    public void deleteNodeAtTail()
    {
        if(head==null)
        {
            System.out.println("LinkedList is Empty");
            return;
        }
        if(head.next==null)
        {
            head = null;
            size--;
            return;
        }
        Node<Integer>temp = head;
        Node<Integer>prev = null;
        while(temp.next != null)
        {
            prev = temp;
            temp = temp.next;
        }
        prev.next = null;
        System.out.println("Deleted Successfully at tail");
        size--;
    }
    public void deleteNodeAtposition(int pos)
    {
        if(pos<=0 || pos>size)
        {
            System.out.println("Invalid Position");
            return;
        }
        if(pos==1 || head==null)
        {
            deleteNodeAtHead();
            return;
        }
        if(pos==size)
        {
            deleteNodeAtTail();
            return;
        }
        Node<Integer>temp = head;
        Node<Integer>prev = head;
        int counter = 0;
        while(prev.next != null)
        {
            counter++;
            if(counter==pos-1)
            {
                break;
            }
            prev = prev.next;
        }
        temp = prev.next;
        prev.next = temp.next;
        temp.next=null;
        System.out.println("Deleted Successfully at given position");
        size--;
    }
    public void insertNodeAtPosition(int data, int pos)
    {
        if(pos>size+1 || pos<=0)
        {
            System.out.println("Invalid position");
            return;
        }
        if(pos==1 || this.head==null)
        {
            insertNodeAtHead(data);
            return;
        }
        if(pos==size+1)
        {
            insertNodeAtTail(data);
            return;
        }
        Node<Integer>newNode = new Node<>(data);
        Node<Integer>temp = head;
        int counter = 1;
        while(counter < pos-1)
        {
            temp = temp.next;
            counter++;
        }
        newNode.next = temp.next;
        temp.next = newNode;
        size++;
        System.out.println("Insertion Seccessfully at given position");
    }
    public void insertNodeAtHead(int data)
    {
        Node<Integer>newNode = new Node<>(data);
        if(this.head==null)
        {
            head = newNode;
            size++;
            System.out.println("Insertion Seccessfully at head");
            return;
        }
        newNode.next = head;
        head = newNode;
        size++;
        System.out.println("Insertion Seccessfully at head");
    }
    public void insertNodeAtTail(int data)
    {
        Node<Integer>newNode = new Node<>(data);
        if(this.head==null)
        {
            head = newNode;
            size++;
            System.out.println("Insertion Seccessfully at tail");
            return;
        }
        Node<Integer>temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
        size++;
        System.out.println("Insertion Seccessfully at tail");
    }
    public void printLinkedList()
    {
        Node<Integer>temp = head;
        System.out.println("*************************************************\nLinkedList Element: ");
        for(int i=1;i<=size;i++)
        {
            System.out.println(temp.data+"\t"+temp.next);
            temp = temp.next;
        }
        System.out.println("*************************************************");
    }
    
    
    public static void main(String[] args) 
    {
        LLIntroduction list = new LLIntroduction();
        list.insertNodeAtHead(800);
        list.printLinkedList();
        list.insertNodeAtHead(900);
        list.printLinkedList();
        list.insertNodeAtHead(500);
        list.printLinkedList();
        list.insertNodeAtHead(100);
        list.printLinkedList();
        list.insertNodeAtPosition(2,1);
        list.printLinkedList();
        list.insertNodeAtPosition(2,1);
        list.printLinkedList();
        list.insertNodeAtPosition(20,2);
        list.printLinkedList();
        list.insertNodeAtPosition(1,3);
        list.printLinkedList();
        list.insertNodeAtTail(5);
        list.printLinkedList();
        list.deleteNodeAtHead();
        list.printLinkedList();
        list.deleteNodeAtHead();
        list.printLinkedList();

        list.printLinkedList();
        list.deleteNodeAtTail();
        list.printLinkedList();
        list.deleteNodeAtTail();
        list.printLinkedList();

        list.printLinkedList();
        list.deleteNodeAtposition(5);
        list.printLinkedList();
        list.deleteNodeAtposition(4);
        list.printLinkedList();
        list.updateNodeValue(111, 3);
        list.printLinkedList();
        System.out.println(list.searchNodeValue(21));
        
    }
}

class Node<T>
{
    T data;
    Node next;
    public Node()
    {
        this.next = null;
    }
    public Node(T data)
    {
        this.next = null;
        this.data = data;
    }
}
