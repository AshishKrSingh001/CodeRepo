public class LC13_RomanToInteger 
{
    public static void main(String[] args) 
    {
        String s = "";
        System.out.println(romanToInt("MCMXCIV"));
    }
    public static int romanToInt(String s) 
    {
        int resNum = 0,i;
        for(i=0;i<s.length()-1;i++)
        {
            char ch = s.charAt(i);
            char ch1 = s.charAt(i+1);
            if(ch == 'M')
            {
                resNum += 1000;
            }
            else if(ch == 'D')
            {
                resNum += 500;
            }
            else if(ch == 'C' && ch1 == 'M')
            {
                resNum += 900;
                i++;
            }
            else if(ch == 'C' && ch1 == 'D')
            {
                resNum += 400;
                i++;
            }
            else if(ch == 'C')
            {
                resNum += 100;
            }
            else if(ch == 'L')
            {
                resNum += 50;
            }
            else if(ch == 'X' && ch1 == 'C')
            {
                resNum += 90;
                i++;
            }
            else if(ch == 'X' && ch1 == 'L')
            {
                resNum += 40;
                i++;
            }
            else if(ch == 'X')
            {
                resNum += 10;
            }
            else if(ch == 'V')
            {
                resNum += 5;
            }
            else if(ch == 'I' && ch1 == 'X')
            {
                resNum += 9;
                i++;
            }
            else if(ch == 'I' && ch1 == 'V')
            {
                resNum += 4;
                i++;
            }
            else if(ch == 'I')
            {
                resNum += 1;
            }
        }
        if(i<s.length())
        {
            char ch = s.charAt(s.length()-1);
            if(ch == 'M')
            {
                resNum += 1000;
            }
            else if(ch == 'D')
            {
                resNum += 500;
            }
            else if(ch == 'C')
            {
                resNum += 100;
            }
            else if(ch == 'L')
            {
                resNum += 50;
            }
            else if(ch == 'X')
            {
                resNum += 10;
            }
            else if(ch == 'V')
            {
                resNum += 5;
            }
            else if(ch == 'I')
            {
                resNum += 1;
            }
        }
        return resNum;
    }
}
