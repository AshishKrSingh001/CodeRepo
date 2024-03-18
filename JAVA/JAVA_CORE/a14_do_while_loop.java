import java.util.Scanner;
public class a42_do_while_loop
{
    public static void main(String[] args)
    {
        System.out.println("Enter a number:");
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        int rem,sum=0;
        do
        {
            rem=num%10;
            sum=sum+rem;
            num=num/10;
        }while(num>0);
        System.out.printf("Sum of the digit is %d\n",sum);

    }
}
