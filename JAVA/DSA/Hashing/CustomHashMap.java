
import java.util.LinkedList;
import java.util.Objects;


public class CustomHashMap<K, V>
{

    // Custom HashMap
    class Hashmap
    {
        K key;
        V value;

        public Hashmap(K key, V value)
        {
            this.key = key;
            this.value = value;
        }

        @Override
        public String toString() {
            return (key +" : "+value);
        }
        
    }
    LinkedList<Hashmap>[]map;
    private int elements;
    private int tableSize;
    private double threshold;

    public CustomHashMap() 
    {
        elements = 0;
        tableSize = 16;
        threshold = 0.75;
        map = new LinkedList[tableSize];
        initializeMap();
    }
    private void initializeMap()
    {
        for(int i=0;i<tableSize;i++)
        {
            map[i] = new LinkedList<>();
        }
    }
    private int getHashCode(K key)
    {
        int hashCode = Objects.hash(key);
        return (Math.abs(hashCode % tableSize));
    }
    private int searchIndex(K key, int hashCode)
    {
        LinkedList<Hashmap> list = map[hashCode];
        for(int index=0;index<list.size();index++)
        {
            if(list.get(index).key == key)
            {
                return index;
            }
        }
        return -1;
    }
    private void rehash()
    {
        LinkedList<Hashmap>oldList[] = map;
        elements = 0;
        tableSize = tableSize*2;
        map = new LinkedList[tableSize];
        initializeMap();
        for(int i=0;i<oldList.length;i++)
        {
            for(Hashmap hm : oldList[i])
            {
                put(hm.key, hm.value);
            }
        }
    }

    public void put(K key, V value)
    {
        int hashCode = getHashCode(key);
        int index = searchIndex(key, hashCode);
        if(index == -1)
        {
            Hashmap hm = new Hashmap(key, value);
            map[hashCode].add(0, hm);
            elements++;
        }
        else
        {
            map[hashCode].get(index).value = value;
        }
        if((elements / tableSize)>threshold)
        {
            rehash();
        }
    }

    public V get(K key)
    {
        int hashCode = getHashCode(key);
        int index = searchIndex(key, hashCode);
        if(index == -1)
        {
            return null;
        }
        return map[hashCode].get(index).value;
    }

    public boolean containsKey(K key)
    {
        int hashCode = getHashCode(key);
        int index = searchIndex(key, hashCode);
        if(index == -1)
        {
            return false;
        }
        return true;
    }

    public Hashmap remove(K key)
    {
        int hashCode = getHashCode(key);
        int index = searchIndex(key, hashCode);
        if(index == -1)
        {
            return null;
        }

        Hashmap hm = map[hashCode].get(index);
        map[hashCode].remove(index);
        return hm;

    }
    public void iterate()
    {
        for(int i=0;i<tableSize;i++)
        {
            for(Hashmap hm : map[i])
            {
                System.out.println(hm);
            }
        }
    }

    
    public static void main(String[] args) 
    {
        System.out.println("Hii");
        CustomHashMap<Integer, String>map = new CustomHashMap<>();
        map.put(101, "Ashish Kumar Singh");
        map.put(102, "Anish");
        map.put(103, "Ayush");
        map.iterate();
        map.remove(103);
        map.put(101, "Suraj");
        System.out.println(map.get(101));
        map.iterate();
        System.out.println(map.containsKey(101));
        System.out.println("Bye");
    }    
}
