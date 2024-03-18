public class a44_pattern
{
    public static void main(String[] args)
    {
        int i,j;
        System.out.println("Pattern 1");
        for (i=1;i<=5;i++)
        {
            for(j=1;j<=i;j++)
            {
                System.out.print("*");
            }
            System.out.print("\n");
        }
        System.out.print("\n\n");

        System.out.println("Pattern 2");
        for(i=5;i>=1;i--)
        {
            for(j=1;j<=i;j++)
            {
                System.out.print("*");
            }
            System.out.print("\n");
        }
        System.out.print("\n\n");

        System.out.println("Pattern 3");
        for(i=1;i<=5;i++)
        {
            for(j=1;j<=5-i;j++)
            {
                System.out.print(" ");
            }
            for(j=1;j<=i;j++)
            {
                System.out.print("*");
            }
            System.out.print("\n");
        }
        System.out.print("\n\n");

        System.out.println("Pattern 4");
        for(i=5;i>=1;i--)
        {
            for(j=1;j<=5-i;j++)
            {
                System.out.print(" ");
            }
            for(j=1;j<=i;j++)
            {
                System.out.print("*");
            }
            System.out.print("\n");
        }
        System.out.print("\n\n");

        System.out.println("Pattern 5");
        for(i=5;i>=1;i--)
        {
            for(j=1;j<=5-i;j++)
            {
                System.out.print(" ");
            }
            for(j=1;j<=2*i-1;j++)
            {
                System.out.print("*");
            }
            System.out.print("\n");
        }
        System.out.print("\n\n");

        System.out.println("Pattern 6");
        for(i=1;i<=5;i++)
        {
            for(j=1;j<=5-i;j++)
            {
                System.out.print(" ");
            }
            for(j=1;j<=2*i-1;j++)
            {
                System.out.print("*");
            }
            System.out.print("\n");
        }
        System.out.print("\n\n");

        System.out.println("Pattern 7");
        for(i=5;i>=1;i--)
        {
            for(j=5;j>i;j--)
            {
                System.out.print(j);
            }
            for(j=1;j<=2*i-1;j++)
            {
                System.out.print(i);
            }
            for(j=1+i;j<=5;j++)
            {
                System.out.print(j);
            }
            System.out.print("\n");
        }
        for(i=1;i<5;i++)
        {
            for(j=5;j>i;j--)
            {
                System.out.print(j);
            }
            for(j=1;j<=2*i-1;j++)
            {
                System.out.print(i);
            }
            for(j=1+i;j<=5;j++)
            {
                System.out.print(j);
            }
            System.out.print("\n");
        }





    }
}
