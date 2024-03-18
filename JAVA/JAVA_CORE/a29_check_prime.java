import java.util.Scanner;
public class a63_check_prime
{
    static void prime_num(int n1,int n2)
    {
        for(int i=n1;i<=n2;i++)
        {
            int count=0;
            for(int j=2;j<=i/2;j++)
            {
                if(i%j==0)
                {
                    count++;
                }
            }
            if(count==0 && i!=1 && i!=0)
            {
                System.out.printf("%d\t",i);
            }
        }
    }
    public static void main(String[] args)
    {
        System.out.println("Enter first number:");
        Scanner sc = new Scanner(System.in);
        int num1 = sc.nextInt();
        System.out.println("Enter second number:");
        int num2 = sc.nextInt();
        System.out.println("Prime number between "+num1+" and "+num2+" :");
        prime_num(num1,num2);

    }
}
