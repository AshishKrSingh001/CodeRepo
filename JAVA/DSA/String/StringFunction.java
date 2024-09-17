
import java.util.Arrays;

public class StringFunction 
{
    public static void main(String[]args)
    {
        String s = "Let's take LeetCode contest";
        System.out.println("*"+s+"*");
        System.out.println("*"+reverseWords(s)+"*");
    }
    public static boolean isAnagram(String a, String b) 
    {
        if(a.length()!=b.length())
            return false;
        int countArray[] = new int[26];
        for(int i=0;i<a.length();i++)
        {
            int index = (int)a.charAt(i)-97;
            countArray[index]++;
        }
        for(int i=0;i<b.length();i++)
        {
            int index = (int)b.charAt(i)-97;
            countArray[index]--;
        }
        for(int i=0;i<countArray.length;i++)
        {
            if(countArray[i]!=0)
                return false;
        }
        return true;
    }
    public static boolean isAnagram2(String a, String b) 
    {
        if(a.length()!=b.length())
            return false;
        char[]x = a.toCharArray();
        char[]y = b.toCharArray();
        Arrays.sort(x);
        Arrays.sort(y);
        for(int i=0;i<x.length;i++)
        {
            if(x[i]!=y[i])
                return false;
        }
        return true;
    }
    public static String reverseWords(String str) 
    {
        int n = str.length();
        StringBuilder s = new StringBuilder("");
        int pos=0;
    
        for(int i=0;i<n;i++)
        {
            if(str.charAt(i)==' ')
            {
                s.append(reverseStringByUsingStringBuilder(str.substring(pos,i))+' ');
                pos = i+1;
            }
        }
        s.append(reverseStringByUsingStringBuilder(str.substring(pos,n)));
        return s.toString();
    }
    public static String reverseWord1(String s) 
    {
        String words[] = s.split(" ");
        StringBuilder str = new StringBuilder("");
        str.append(words[words.length-1]);
        for(int i=words.length-2;i>=0;i--)
        {
            // System.out.println("*"+words[i]+"*");
            if(words[i].length()!=0)
            {
                str.append(" " + words[i]);
            }
        }
        
        return str.toString();
    }
    public static String reverseEachWord(String str) 
    {
        int n = str.length();
        StringBuilder s = new StringBuilder("");
        int pos=n,i = n-1;
        while(str.charAt(i) == ' ')
            i--;

        while(i>=0)
        {
            if(str.charAt(i)==' ' && str.charAt(i+1)==' ')
            {
                pos--;
            }
            else if(str.charAt(i)==' ')
            {
                s.append(str.substring(i+1,pos) + ' ');
                pos = i;
            }
            i--;
        }
        if(str.charAt(0)!=' ')
            s.append(str.substring(0,pos));
        return s.toString();
    }
    public static boolean palindromeString(String str)
    {
        // return(str.equals(reverseStringCharByChar(str)));
        // return(str.equals(reverseStringByUsingStringBuilder(str)));

        for(int i=0;i<str.length();i++)
        {
            if(str.charAt(i)!=str.charAt(str.length()-1-i))
                return false;
        }
        return true;
    }
    public static String reverseStringCharByChar(String str)
    {
        String s="";
        for(int i=str.length()-1;i>=0;i--)
        {
            s += str.charAt(i);
        }
        return s;
    }
    public static void printAllSubString(String str)
    {
        System.err.println("String is "+str);
        for(int i=0;i<str.length();i++)
        {
            for(int j=i+1;j<=str.length();j++)
            {
                System.err.println(str.substring(i,j));
            }
        }
    } 

    private static char reverseStringByUsingStringBuilder(String substring) {
        throw new UnsupportedOperationException("Not supported yet.");
    }
}
