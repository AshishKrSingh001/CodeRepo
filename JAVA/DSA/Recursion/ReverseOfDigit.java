public class ReverseOfDigit 
{
    public static void reverseNum(int num)
    {
        if(num <= 0)
            return;
        System.out.print((num%10));
        reverseNum(num/10);
    }
    public static void main(String[] args) 
    {
        reverseNum(125);
    }
}
