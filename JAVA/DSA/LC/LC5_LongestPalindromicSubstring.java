public class LC5_LongestPalindromicSubstring 
{
    public static void main(String[] args) 
    {
        String s = "a";
        System.out.println(longestPalindrome(s));
    }
    public static String longestPalindrome(String s) 
    {
        if(s.length()==1)
        return s;
        String resString = "";
        for(int i=0;i<s.length()-1;i++)
        {
            String res = "";
            for(int j=s.length();j>=i;j--)
            {
                res = s.substring(i,j);
                System.out.println(res);
                System.out.println(isPalindrome(res));
                if(isPalindrome(res))
                {
                    break;
                }
            }
            if(isPalindrome(res))
            {
                if(res.length()>resString.length())
                    resString = res;
            }
        }
        return resString;
    }
    public static boolean isPalindrome(String s)
    {
        int n = s.length();
        for(int i=0;i<n/2;i++)
        {
            if(!(s.charAt(i)==s.charAt(n-i-1)))
                return false;
        }
        return true;
    }
}
