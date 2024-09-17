
import java.util.ArrayList;
import java.util.Stack;

class StockSpanner 
{
    Stack<Integer>stack;
    ArrayList<Integer>list;

    public StockSpanner() 
    {
        stack = new Stack<>();
        list = new ArrayList<>();
    }
    
    public int next(int price) 
    {
        list.add(price);
        while(!stack.isEmpty() && list.get(stack.peek()) <= price)
        {
            stack.pop();
        }
        int top = (stack.isEmpty())?-1:stack.peek();
        int currentIndex = list.size()-1;
        int res = currentIndex - top;
        stack.push(currentIndex);
        return res;
    }
    public static void main(String[] args) 
    {
        StockSpanner stockSpanner = new StockSpanner();
        System.out.println(stockSpanner.next(100)); // return 1
        System.out.println(stockSpanner.next(80));  // return 1
        System.out.println(stockSpanner.next(60));  // return 1
        System.out.println(stockSpanner.next(70));  // return 2
        System.out.println(stockSpanner.next(60));  // return 1
        System.out.println(stockSpanner.next(75));  // return 4
    }
}