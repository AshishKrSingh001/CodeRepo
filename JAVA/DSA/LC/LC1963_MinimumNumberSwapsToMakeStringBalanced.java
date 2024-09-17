public class LC1963_MinimumNumberSwapsToMakeStringBalanced
{
    public static int minSwaps(String s) 
    {
        int open=0, close=0;
        for(int i=0;i<s.length();i++)
        {
            char ch = s.charAt(i);
            if(ch == '[')
                open++;
            else
            {
                if(open<=0)
                    close++;
                else
                    open--;
            }
        }
        return ((open%2==0)?(open/2):(open/2+1));
    }
    public static void main(String[] args) 
    {
        System.out.println(minSwaps("][]["));
        System.out.println(minSwaps("]]][[["));
    }  
}
