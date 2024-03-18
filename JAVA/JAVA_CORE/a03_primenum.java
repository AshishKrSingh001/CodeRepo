//package prime;
public class a01_primenum
{
    public static void prime_num(int n1,int n2)
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
        prime_num(1, 100);
        System.out.println("\nHello World");
    }
}
