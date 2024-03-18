import java.util.Scanner;
public class a41_while_loop
{
    public static void main(String[] args)
    {
        System.out.println("Enter a number:");
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        int n = num;
        int rem,rev=0;
        while(num>0)
        {
            rem=num%10;
            rev=rev*10+rem;
            num=num/10;
        }
        System.out.printf("Reverse of the digit is %d\n",rev);
        if(n==rev)
        {
            System.out.println("palindrome");
        }
        else
        {
            System.out.println("Not palindrome");
        }
    }
}
