
import java.util.List;
import java.util.ArrayList;
import java.util.HashMap;

public class LetterCombinationOfPhoneNumber 
{
    public static void main(String[] args) 
    {
        System.out.println(letterCombinations("23"));
    }
    public static List<String> letterCombinations(String digits) 
    {
        HashMap<Character,String>map = new HashMap<Character,String>();
        map.put('2',"abc");
        map.put('3',"def");
        map.put('4',"ghi");
        map.put('5',"jkl");
        map.put('6',"mno");
        map.put('7',"pqrs");
        map.put('8',"tuv");
        map.put('9',"wxyz");

        List<String> numSeq = new ArrayList<>();
        recur(digits, 0, "", numSeq, map);
        return numSeq;
    }
    public static void recur(String digits, int index, String cur, List<String>numSeq, HashMap<Character,String>map)
    {
        // Base case
        if(index == digits.length())
        {
            numSeq.add(cur);
            return;
        }
        // repeatative task
        char curDigit = digits.charAt(index); // 2
        String curAlphabets = map.get(curDigit); // abc
        for(int i=0; i<curAlphabets.length();i++)
        {
            cur += curAlphabets.charAt(i);
            recur(digits, index+1, cur, numSeq, map);
            cur = cur.substring(0,cur.length()-1);
        }

    }
}
