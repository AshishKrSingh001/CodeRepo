



public class DoublyLinkedList 
{
    Node<Integer>head;
    int size;
    public DoublyLinkedList()
    {
        head = null;
        int size = 0;
    }
    public int length()
    {
        return size;
    }
    public void printLinkedList()
    {
        Node<Integer>temp = head;
        System.out.println("*************************************************\nLinkedList Element: ");
        for(int i=1;i<=size;i++)
        {
            System.out.println("Sr.no: "+i+"\t"+temp.prev+"\t"+temp.data+"\t"+temp.next+"\t->"+temp);
            temp = temp.next;
        }
        System.out.println("*************************************************");
    }
    public void insertValueAtHead(int data)
    {
        Node<Integer>newNode = new Node<>(data);
        if(head==null)
        {
            head = newNode;
            size++;
            System.out.println("Insertion of "+data+" at head successfully");
            return;
        }
        newNode.next = head;
        head.prev = newNode;
        head = head.prev;
        size++;
        System.out.println("Insertion of "+data+" at head successfully");
    }
    public void insertValueAtTail(int data)
    {
        Node<Integer>newNode = new Node<>(data);
        if(head==null)
        {
            head = newNode;
            size++;
            System.out.println("Insertion of "+data+" at  tail successfully");
            return;
        }
        Node<Integer>temp = head;
        while(temp.next!=null)
        {
            temp = temp.next;
        }
        newNode.prev = temp;
        temp.next = newNode;
        size++;
        System.out.println("Insertion  of "+data+" at tail successfully");
    }
    public void insertValueAtPosition(int data, int pos)
    {
        if(pos<=0 || pos>size+1)
        {
            System.out.println("Invalid Position");
            return;
        }
        Node<Integer>newNode = new Node<>(data);
        if(head==null || pos==1)
        {
            insertValueAtHead(data);
            return;
        }
        if(pos==size+1)
        {
            insertValueAtTail(data);
            return;
        }
        Node<Integer>temp = head;
        Node<Integer>node;
        int counter=0;
        while(temp.next!=null)
        {
            counter++;
            if(counter == pos-1)
                break;
            temp = temp.next;
        }
        newNode.prev = temp;
        newNode.next = temp.next;
        temp.next = newNode;
        newNode = newNode.next;
        newNode.prev = temp.next;
        size++;
        System.out.println("Insertion of "+data+" at "+pos+" successfully");
    }
    public void deleteValueAtHead()
    {
        if(head==null)
        {
            System.out.println("LinkedList is Empty deletion failed");
            return;
        }
        Node<Integer>temp = head;
        head = head.next;
        head.prev = null;
        temp.next=null;
        size--;
        System.out.println("Deletion at head successfully");
    }
    public void deleteValueAtTail()
    {
        if(head==null)
        {
            System.out.println("LinkedList is Empty deletion failed");
            return;
        }
        Node<Integer>temp = head;
        Node<Integer>node;
        while(temp.next!=null)
        {
            temp = temp.next;
        }
        node = temp.prev;
        node.next = null;
        temp.prev=null;
        size--;
        System.out.println("Deletion at tail successfully");
    }
    public void deleteValueAtPosition(int pos)
    {
        if(pos<=0 || pos>size)
        {
            System.out.println("Invalid Position");
            return;
        }
        if(head==null || pos==1)
        {
            deleteValueAtHead();
            return;
        }
        if(pos==size)
        {
            deleteValueAtTail();
            return;
        }
        Node<Integer>temp = head;
        Node<Integer>node;
        int counter=0;
        while(temp.next!=null)
        {
            counter++;
            if(counter == pos-1)
                break;
            temp = temp.next;
        }
        node = temp.next;
        temp.next = node.next;
        temp=node.next;
        temp.prev = node.prev;
        node.next=null;
        node.prev=null;
        size--;
        System.out.println("Deletion at "+pos+" successfully");
    }

    public static void main(String[] args) 
    {
        DoublyLinkedList dll = new DoublyLinkedList();
        dll.insertValueAtHead(100);
        dll.insertValueAtHead(200);
        dll.insertValueAtHead(300);
        dll.insertValueAtTail(1000);
        dll.insertValueAtTail(700);
        dll.insertValueAtTail(770);
        dll.insertValueAtPosition(111,1);
        dll.insertValueAtPosition(222,1);
        dll.insertValueAtPosition(222,dll.length()+1);
        dll.insertValueAtPosition(111,dll.length()+1);
        dll.insertValueAtPosition(171,4);
        dll.insertValueAtPosition(1141,6);
        dll.printLinkedList();
        dll.deleteValueAtHead();dll.printLinkedList();
        dll.deleteValueAtHead();dll.printLinkedList();
        dll.deleteValueAtTail();dll.printLinkedList();
        dll.deleteValueAtTail();dll.printLinkedList();
        dll.deleteValueAtPosition(5);dll.printLinkedList();
        dll.deleteValueAtPosition(4);dll.printLinkedList();
    }
}

class Node<T>
{
    int data;
    Node next;
    Node prev;
    public Node()
    {
        this.next = null;
        this.prev = null;
    }
    public Node(int data)
    {
        this.next = null;
        this.prev = null;
        this.data = data;
    }
}
