
public class PalindromeSubString 
{
    public static void palindrome(String s, int index, int n)
    {
        if(index == n)
        {
            return;
        }
        for(int i=index; i<n; i++)
        {
            if(isPalindrome(s, index, i))
            {
                System.out.print(s.substring(index,i+1)+" ");
                palindrome(s, i+1, n);
                System.out.println("");
            }
        }
    }
    public static boolean isPalindrome(String s, int i, int j)
    {
        while(i<j)
        {
            if(s.charAt(i)!=s.charAt(j))
                return false;
            i++;
            j--;
        }
        return true;
    }
    public static void main(String[]args)
    {
        System.out.println("Try programiz.pro");
        String s = "ABCDCBA";
        palindrome(s, 0, s.length());
    }
}
