import java.util.Scanner;
public class a64_recursion_add
{
    static int SumOf_n_Number(int num)
    {
        if(num==0)
        {
            return 0;
        }
        else
        {
            return num+SumOf_n_Number(num-1);
        }
    }
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a number:");
        int a = sc.nextInt();
        System.out.println("Sum of "+a+" number = "+SumOf_n_Number(a));
    }

}
