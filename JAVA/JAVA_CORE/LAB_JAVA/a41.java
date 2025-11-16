//Write a program to give example for multiple inheritance in Java.
package LAB_JAVA;

import java.util.Scanner;

class Rectangle_
{
    protected double len,bre;
    Scanner sc = new Scanner(System.in);
}
class Input extends Rectangle_
{
    Input()
    {
        System.out.println("Enter length and breadth");
        len = sc.nextDouble();
        bre = sc.nextDouble();
    }
}
class Output extends Input
{
    Output()
    {
        System.out.println("Area: "+(len*bre));
        System.out.println("Area: "+2*(len+bre));
    }
}
public class a41 
{
    public static void main(String[] args) 
    {
        Rectangle_ rec = new Output();
    }    
}
