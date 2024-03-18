import java.util.Scanner;

public class a02_root_square
{
    public static void main(String[] arg)
    {
        Scanner sc = new Scanner(System.in);
        int a,sq;
        System.out.println("Enter a number:");
        a = sc.nextInt();
        sq = a*a;
        double rt = Math.sqrt(a);
        System.out.println("Square of "+a+" = "+sq+"\nRoot of "+a+" = "+rt);

    }
}
