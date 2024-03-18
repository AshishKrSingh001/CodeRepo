import java.util.Scanner;
public class a61_methods_basics
{
    static int sub(int x,int y)
    {
        return x+y;
    }
    static void add(int x,int y)
    {
        System.out.println("Addition = "+ x+y);
    }

    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter two number");
        int a = sc.nextInt();
        int b = sc.nextInt();
        add(a,b);
        System.out.println("Subtraction = " + sub(a,b));
    }
}
