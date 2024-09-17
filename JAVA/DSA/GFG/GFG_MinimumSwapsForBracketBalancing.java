public class GFG_MinimumSwapsForBracketBalancing 
{
    public static int minimumNumberOfSwaps(String s) 
    {
        int open=0, close=0, ubc=0, swaps=0;
        // open,close,ubc,swaps for counting open brackets, closed brackets,unbalanced closed brackets, minimum no of swaps respectively
        for(int i=0;i<s.length();i++)
        {
            if(s.charAt(i) == '[')
            {
                open++;
                if(ubc>0)
                {
                    swaps += ubc;
                    ubc--;
                }
            }
            else
            {
                close++;
                if(open-close!=0)
                {
                    ubc++;
                }
            }

        }
        return swaps;
    }
    public static void main(String[] args) 
    {
        System.out.println(minimumNumberOfSwaps("[]][]["));
        // System.out.println(minimumNumberOfSwaps("[]][]["));
    }
}
