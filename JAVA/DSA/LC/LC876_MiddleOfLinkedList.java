public class LC876_MiddleOfLinkedList 
{
    public static void main(String[] args) 
    {
        System.out.println();
    }
    public static ListNode middleNode(ListNode head) 
    {
        ListNode fast = head;
        ListNode slow = head;
        while(fast.next==null)
        {
            slow = slow.next;
            fast = fast.next;
            fast = fast.next;
            if(fast==null)
                return slow;
        }
        return slow;
    }
}
class ListNode 
{
    int val;
    ListNode next;     ListNode() {}
    ListNode(int val) { this.val = val; }
    ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}