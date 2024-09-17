
import java.util.*;

public class MapExample
{
    public static void main(String[] args) 
    {
        System.out.println("Map Example");

        // Map<Integer, String>classMap = new HashMap();
        // Map<Integer, String>classMap = new TreeMap();
        Map<Integer, String>classMap = new TreeMap(Collections.reverseOrder());

        classMap.put(101, "Ashish");
        classMap.put(101, "Abhishek");
        classMap.put(10111, "Animash");
        classMap.putIfAbsent(101, "Anirudh");
        classMap.put(1025, "Aman");
        classMap.put(1031, "Aakash");
        classMap.put(104, "Anish");
        classMap.put(105, "Kumar");

        System.out.println(classMap);

        // System.out.println(classMap.get(101));
        // System.out.println(classMap.get(1));
        // System.out.println(classMap.get(105));
        // System.out.println(classMap.get(103));
        // System.out.println(classMap.get(102));
        // System.out.println(classMap.get(101));

        // System.out.println(classMap.getOrDefault(1,"No one"));
        // System.out.println(classMap.getOrDefault(105,"No one"));
        // System.out.println(classMap.getOrDefault(103,"No one"));
        // System.out.println(classMap.getOrDefault(102,"No one"));
        // System.out.println(classMap.getOrDefault(107,"No one"));


        // System.out.println(classMap.containsKey(5));
        // System.out.println(classMap.containsKey(105));
        // System.out.println(classMap.containsKey(500));


        // System.out.println(classMap.containsValue("Ashish"));
        // System.out.println(classMap.containsValue("Anirudh"));
        // System.out.println(classMap.containsValue("Aman"));
        // System.out.println(classMap.containsValue("Animash"));

        for(Map.Entry<Integer,String>map : classMap.entrySet())
        {
            System.out.println(map.getKey()+" -> "+map.getValue());
        }
        // System.out.println("******************************");
        // for(String value:classMap.values())
        // {
        //     System.out.println(value);
        // }
        // System.out.println("******************************");
        // for(Integer key:classMap.keySet())
        // {
        //     System.out.println(key);
        // }
    }    
}
