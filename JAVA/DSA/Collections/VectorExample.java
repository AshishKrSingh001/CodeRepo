import java.util.*;
public class VectorExample 
{
    public static void main(String[] args) 
    {
        System.out.println("Vector Example");
        List<Integer>list = new Vector<>();// Syncronized
        list.add(10);
        list.add(20);
        list.add(100);
        list.add(1);
        list.add(50);
        list.add(0,0);
        list.add(70);
        System.out.println(list);
        list.remove(Integer.valueOf(10));
        System.out.println(list);
        list.remove(Integer.valueOf(0));
        System.out.println(list);
        System.out.println(list.contains(100));
        System.out.println(list.get(3));
        System.out.println(list.set(3,1000));
        System.out.println(list.get(3));
        System.out.println(list);
        list.sort(new Comparator<Integer>() {
            public int compare(Integer A, Integer B)
            {
                return A-B;
            }
        });
        System.out.println(list);
        list.sort(new Comparator<Integer>() {
            public int compare(Integer A, Integer B)
            {
                return B-A;
            }
        });
        System.out.println(list);  
    }
}
