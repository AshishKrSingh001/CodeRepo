public class ZerosInFactorial 
{
    public static void main(String[] args) 
    {
        System.out.println(factorial(15));
        System.out.println(countTrailingOfZeros(15));
    }
    public static long factorial(int num)
    {
        if(num==1)
        {
            return 1;
        }
        return num * factorial(num-1);
    }
    public static int countTrailingOfZeros(int num)
    {
        int count = num/5;
        return count;
    }
}
