/*
 * Write a program for the following
    a. Example for call by value.
    b. Example for call by reference.
 */
package LAB_JAVA;

import java.util.Scanner;

class Q
{
    int a;
    void input()
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a number: ");
        a=sc.nextInt();
    }
}
public class a33 
{
    public static void swap(Q a,Q b)
    {
        Q c = new Q();
        c.a=a.a;
        a.a=b.a;
        b.a=c.a;
        System.out.println("call by Reference\nvalue of a: "+a.a+"\nvalue of b: "+b.a);
    }
    public static void swapping(int a,int b)
    {
        int c=a;
        a=b;
        b=c;
        System.out.println("call by value\nvalue of a: "+a+"\nvalue of b: "+b);
    }
    public static void main(String[] args) 
    {
        Q o = new Q();
        o.input();
        Q p = new Q();
        p.input();
        System.out.println("Before Swapping\nvalue of a: "+o.a+"\nvalue of b: "+p.a);
        swap(o, p);
        System.out.println("After call by Reference\nvalue of a: "+o.a+"\nvalue of b: "+p.a);
        swapping(o.a, p.a);
        System.out.println("After call by value\nvalue of a: "+o.a+"\nvalue of b: "+p.a);

    }
}
