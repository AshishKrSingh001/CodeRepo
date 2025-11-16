// Write a program to give the example for ‘this’ operator. And also use the ‘this’ keyword as return statement.
package LAB_JAVA;

import java.util.Scanner;

public class a34 
{
    double x;
    Scanner sc=new Scanner(System.in);
    a34()
    {
        System.out.println("Enter thevalue of X: ");
        x=sc.nextInt();
    } 
    a34 getdata()
    {
        return this;
    }
    public static void main(String[] args) 
    {
        a34 a = new a34();
        System.out.println(a.getdata().x);
    }
}

