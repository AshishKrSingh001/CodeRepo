/*
Operator: It is used to perform operation on variable and values.

There are many types of Operator:
    Arithmetic Operator: +, -, *, /, %, ++, --;
    Assignment Operator: = ,+=;
    Comparison Operator: ==, <=, >=, >, <;
    Logical Operator:    &&, ||, !;
    Bitwise Operator:    &, |;
*/
import java.util.Scanner;
public class a11_operator
{
    public static void main(String[] arg)
    {
        // WAP to input 4 number and find  first one is greatest or not;
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter four number:");
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        int d = sc.nextInt();
        System.out.println(b<a && c<a && d<a);
    }
}
