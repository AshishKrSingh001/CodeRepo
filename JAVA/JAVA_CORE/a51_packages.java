import java.util.*;
//import java.util.Scanner;


public class a131_packages
{
    public static void main(String[] args)
    {
        java.util.Scanner sc = new java.util.Scanner(System.in);
        System.out.println("Enter a number:");
        int  num = sc.nextInt();
        System.out.println("Your number is " +num);
        Random r = new Random();
        int ran = r.nextInt(1,10);
        System.out.println("Random number is "+ran);
    }
}
