//Write a Java program to display default value of all primitive data types of Java
package LAB_JAVA;

import java.util.Scanner;

public class a02 
{
    private byte a;
    private short b;
    private int c;
    private long d;
    private float e;
    private double f;
    private char g;
    private boolean h;
    public static void main(String[] args) 
    {
        a02 obj = new a02();
        System.out.println("byte: "+obj.a+"\nshort: "+obj.b+"\nint: "+obj.c+"\nlong: "+obj.d+"\nfloat: "+obj.e+"\ndouble: "+obj.f+"\nchar: "+obj.g+"\nboolean: "+obj.h);
        String s1,s2;
        System.out.println("Enter a string: ");
        Scanner sc = new Scanner(System.in);
        s1 = sc.nextLine();
        s2=s1;
        System.out.println(s2);

    }
}
