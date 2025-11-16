public class GFG_PairwiseSwapElementsOfLinkedList 
{
    public Node pairwiseSwap(Node head) 
    {
        Node a = head;
        Node b = head.next;
        head = b;
        while(b.next!=null)
        {
            a.next = b.next;
            b.next = a;

            a = a.next;
            b = a.next;

        }
        return head;
    }
    class Node
{
    int data;
    Node next;
    Node(int key)
    {
        data = key;
        next = null;
    }
}
}
