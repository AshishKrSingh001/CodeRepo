
import java.util.HashSet;
import java.util.Iterator;

public class HashSetExample 
{
    public static void main(String[] args) 
    {
        HashSet<Integer>set = new HashSet<>();
        set.add(10);    
        set.add(10);   
        System.out.println(set.contains(10)); 
        set.add(30);    
        set.add(20);    
        set.add(10); 
        Iterator<Integer>itr = set.iterator();
        while(itr.hasNext())
        {
            System.out.println(itr.next());
            // itr.remove();
        }
        System.out.println(set);
        System.out.println(set.remove(10));
        System.out.println(set);
    }    
}
