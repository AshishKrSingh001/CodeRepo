import java.util.ArrayList;
import java.util.List;

public class PalindromeSubString 
{
    public static boolean palindrome(String s)
    {
        if(s.length()==1)
            return true;
        for(int i=0;i<=(s.length()/2)-1;i++)
        {
            if(s.charAt(i)!=s.charAt(s.length()-1 - i))
                return false;
        }
        return true;
    }
    public static void findPermutations(String s, int index, List<List<String>>res)
    {
        int n = s.length();
        if(index == n)
        {
            List<String>subList = new ArrayList<>();
            for(int i=0;i<n;i++)
            {
                subList.add(s.substring(i,index));
            }
            res.add((new ArrayList<>(subList)));
            return;
        }
       
    }
    public static void main(String[] args) 
    {
        System.out.println(palindrome(""));
    }
}
