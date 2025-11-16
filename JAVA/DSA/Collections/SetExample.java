// import java.util.HashSet;
import java.util.*;

public class SetExample 
{
    public static void main(String[] args) 
    {
        // Set<Integer>set = new LinkedHashSet<>();
        // Set<Integer>set = new TreeSet<>();
        Set<Integer>set = new TreeSet<>(Collections.reverseOrder());
        // Set<Integer>set = new HashSet<>();
        set.add(1);  
        set.add(2);  
        set.add(2);  
        set.add(3);  
        set.add(5);  
        set.add(5);  
        set.add(4);  
        set.add(0);  
        System.out.println(set);

        // System.out.println(set.remove(2));
        // System.out.println(set.remove(20));
        // System.out.println(set.remove(4));
        // System.out.println(set.remove(3));
        System.out.println(set);

        System.out.println(set.contains(2));
        System.out.println(set.contains(0));

        Iterator<Integer>itr = set.iterator();
        while(itr.hasNext())
        {
            System.out.println(itr.next());
        }
    }    
}
