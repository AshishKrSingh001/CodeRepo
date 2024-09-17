import java.util.Collections;
import java.util.PriorityQueue;
import java.util.Queue;
public class QueueExample 
{
    public static void main(String[] args) 
    {
        // Queue<Integer>queue = new LinkedList<>();
        // Queue<Integer>queue = new ArrayDeque<>();
        // Queue<Integer>queue = new PriorityQueue<>();
        // Queue<Integer>queue = new PriorityQueue<>(Comparator.reverseOrder());
        Queue<Integer>queue = new PriorityQueue<>(Collections.reverseOrder());

        queue.offer(10);
        queue.offer(100);
        queue.offer(15);
        queue.offer(18);
        queue.offer(20);
        queue.offer(78);
        queue.offer(10);
        queue.offer(10);
        System.out.println(queue);

        System.out.println(queue.poll());
        System.out.println(queue);
        System.out.println(queue.peek());

        System.out.println(queue.poll());
        System.out.println(queue);
        System.out.println(queue.peek());


        // Deque<Integer>queue = new ArrayDeque<>();
        // Deque<Integer>queue = new LinkedList<>();

        // queue.offer(10);
        // queue.offerFirst(100);
        // queue.offerLast(15);
        // queue.offerLast(18);
        // queue.offer(20);
        // queue.offerFirst(78);
        // queue.offerLast(10);
        // queue.offerFirst(10);
        // System.out.println(queue);

        // System.out.println(queue.poll());
        // System.out.println(queue);
        // System.out.println(queue.peek());

        // System.out.println(queue.pollFirst());
        // System.out.println(queue);
        // System.out.println(queue.peekFirst());

        // System.out.println(queue.pollLast());
        // System.out.println(queue);
        // System.out.println(queue.peekLast());

    }
}
