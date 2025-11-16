/*
    Write a program to create interface named test. In this interface the
    member function is square. Implement this interface in arithmetic class.
    Create one new class called ToTestInt in this class use the object of
    arithmetic class
 */
package LAB_JAVA;

import java.util.Scanner;

interface Itest
{
    double square();
}
class CArithmetic implements Itest
{
    int n;
    CArithmetic()
    {
        System.out.println("Enter a number: ");
        Scanner sc = new Scanner(System.in);
        n=sc.nextInt();
    }
    public double square()
    {
        return Math.pow(n,2);
    }
}
class ToTestInt
{
    CArithmetic a = new CArithmetic();
    ToTestInt()
    {
        System.out.println("Squate of Given number is: "+a.square());
    }
}
public class a42 
{
    public static void main(String[] args) 
    {
        ToTestInt t = new ToTestInt();
    }    
}
