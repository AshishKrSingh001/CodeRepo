public class ConversionDecimalBinary 
{
    public static int decimalToBinary(int num)
    {
        if(num == 0)
        {
            return 0;
        }
        return ((num%2) + decimalToBinary(num/2) * 10);
    }
    public static int binaryToDecimal(int num)
    {
        if(num == 0)
        {
            return 0;
        }
        return ((num%10) + binaryToDecimal(num/10) * 2);
    }
    public static void main(String[] args) 
    {
        System.out.println(decimalToBinary(5));
        System.out.println(binaryToDecimal(101));
    }
}
