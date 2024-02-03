// Write a program to give a simple example for abstract class.
package LAB_JAVA;

import java.util.Scanner;

abstract class Person
{
    int id;
    String name;
    Person()
    {
        System.out.println("Hello");
    }
    Scanner s = new Scanner(System.in);
    abstract void input();
    abstract void output();
}
class Employee extends Person
{
    void input()
    {
        System.out.println("Enter your name and id");
        name = s.nextLine();
        id = s.nextInt();
    }
    void output()
    {
        System.out.println("Name: "+name+"\nId: "+id);
    }
}
class Student extends Person
{
    void input()
    {
        System.out.println("Enter your name and id");
        name = s.nextLine();
        id = s.nextInt();
    }
    void output()
    {
        System.out.println("Name: "+name+"\nId: "+id);
    }
}
public class a39 
{
    public static void main(String[] args) 
    {
        Person e = new Employee();
        e.input();
        e.output();
        Person s = new Student();
        s.input();
        s.output();
    }    
}
