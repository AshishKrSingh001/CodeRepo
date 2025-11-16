public class FactorialNumber 
{
    public static long factorialNumber(int num) 
    {
        if(num==1)
            return 1;
        return num * factorialNumber(num-1);
    }
    public static void main(String[] args) 
    {
        System.out.println(factorialNumber(5));
    }
}
