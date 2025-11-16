
import java.util.*;

public class Permutations
{
    public static void swap(char[]ch, int i, int j)
    {
        char temp = ch[i];
        ch[i] = ch[j];
        ch[j] = temp;
    }
    public static void findPermutations(char[]ch, int index,List<List<Character>>res)
    {
        int n = ch.length;
        // base case
        if(index == n)
        {
            List<Character>subList = new ArrayList<>();
            for(char el : ch)
            {
                subList.add(el);
            }
            res.add(new ArrayList<>(subList));
            return;
        }
        // task;
        for(int i = index; i<n; i++)
        {
            swap(ch, i, index);

            findPermutations(ch, index+1, res);

            swap(ch, i, index);
        }
    }
    public static void main(String[] args) 
    {
        String s = "ABC";
        List<List<Character>>list = new ArrayList<>();
        findPermutations(s.toCharArray(), 0, list);
        System.out.println(list.size());
        for(List l : list)
        {
            for(Object c : l)
            {
                System.out.print(c+" ");
            }
            System.out.println("");
        }
    }
}