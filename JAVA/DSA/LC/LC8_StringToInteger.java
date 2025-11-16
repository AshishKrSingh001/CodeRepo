public class LC8_StringToInteger 
{
    public static void main(String[] args) 
    {
        String s = "-2147483647";
        System.out.println(myAtoi(s));
    }
    public static int myAtoi(String s) 
    {
        if(s.length()==0)
            return 0;
        boolean flag = false;
        long resNum = 0;
        int k;
        for(k=0;k<s.length() && s.charAt(k)==' ';k++);
        if(k<s.length() && s.charAt(k)=='-')
        {
            flag = true;
            k++;
        }
        else if(k<s.length() && s.charAt(k)=='+')
            k++;
        for(int i=k;i<s.length();i++)
        {
            char ch = s.charAt(i);
            if(Character.isDigit(ch))
            {
                int num = (int)ch-48;
                resNum = resNum * 10 + num;
            }
            else
                break;
            
            if(resNum > 2147483647)
            {
                if(flag)
                    resNum = 0 - resNum;
                return(resNum<=-2147483648)?-2147483648:2147483647;
            }
            // System.out.println(resNum);
            // System.out.println(flag);
        }
        System.out.println(resNum);
        System.out.println(flag);
        if(flag)
            return 0 - (int)resNum;
        return (int)resNum;
    }
}
