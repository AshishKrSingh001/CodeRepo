
import java.util.*;

public class LC3_LongestSubstringWithoutRepeatingCharacters
{
    public static void main(String[] args) 
    {
        String s = "abcabcbb";
        System.out.println(lengthOfLongestSubstring(s));
    }
    public static int lengthOfLongestSubstring(String s) 
    {
        Set<Character>charSet = new HashSet<>();
        int count=0;
        for(int i=0;i<s.length();i++)
        {
            int resCount;
            if(charSet.add(s.charAt(i)))
                resCount = charSet.size();
            else
            {
                resCount = charSet.size();
                charSet.removeAll(charSet);
                for(int j=i;j>=0;j--)
                {
                    if(!charSet.add(s.charAt(j)))
                        break;
                }
            }
            System.out.println(charSet);
            if(resCount>count)
                count = resCount;
        }
        return count;
    }
}