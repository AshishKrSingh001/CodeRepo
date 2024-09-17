public class RecirsionIntroduction 
{
    public static void printUpToN(int num)
    {
        if(num == 0)
            return;
        System.out.println(num);
        printUpToN(num-1);
    }
    public static void printUpToM(int num)
    {
        printUpToN(num-1);
        if(num == 0)
            return;
        System.out.println(num);
    }
    public static void main(String[] args) 
    {
        printUpToM(5);
    }    
}
