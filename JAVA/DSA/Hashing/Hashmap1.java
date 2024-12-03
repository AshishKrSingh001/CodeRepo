
import java.util.HashMap;

public class Hashmap1 
{
    public static void main(String args[])
    {
        HashMap<Integer, String> map = new HashMap<>();
        map.put(101, "Ashish Kumar Singh");
        map.put(102, "Anish Kumar Roy");
        map.put(103, "Ritesh Mishra");
        map.put(104, "Ratnesh Das");
        map.put(105, "Abhishek Singh");

        for(int key : map.keySet())
        {
            System.out.println(key+" : "+map.get(key));
        }

        map.put(102, "Anamika");

        for(int key : map.keySet())
        {
            System.out.println(key+" : "+map.get(key));
        }
    }
}
