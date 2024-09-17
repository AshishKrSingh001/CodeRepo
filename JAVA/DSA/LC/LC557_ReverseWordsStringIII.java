public class LC557_ReverseWordsStringIII
{
    public static void main(String[]args)
    {
        String str = "Let's take LeetCode contest";
        System.err.println("*"+reverseWords(str)+"*");

    }
    public static String reverseWords(String str) 
    {
        char ch[] = str.toCharArray();
        int n = ch.length;
        int pos=0;
    
        for(int i=0;i<n;i++)
        {
            if(ch[i]==' ')
            {
                ch = reverseStringCharByChar(ch, pos, i-1);
                pos = i+1;
            }
        }
        ch = reverseStringCharByChar(ch, pos, n-1);
        return new String(ch);
    }
    public static char[] reverseStringCharByChar(char[]ch, int startIndex, int endIndex)
    {
        for(int i=startIndex,j=endIndex;i<=(endIndex+startIndex)/2;i++,j--)
        {
            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;
        }
        return ch;
    }
}