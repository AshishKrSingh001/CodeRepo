

import java.util.Scanner;

public class a01_area_of_trangle
{
    public static void main(String[] args)
    {
        System.out.println("Hello world!");
        System.out.println("Enter Sides of trangle");
        Scanner s = new Scanner(System.in);
        int a = s.nextByte();
        int b = s.nextByte();
        int c = s.nextByte();
        int s1 = (a+b+c)/2;
        int area = (s1*(s1-a)*(s1-b)*(s1-c))^(1/2);
        System.out.println("Area = "+area);

    }
}