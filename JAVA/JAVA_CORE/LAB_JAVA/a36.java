/*
 * Write a program to create a class named shape. In this class we have three
    sub classes circle, triangle and square each class has two member function
    named draw () and erase (). Create these using polymorphism concepts.
 */
package LAB_JAVA;
class Shape1
{
    void draw1()
    {
        System.out.println("Draw a shape");
    }
    void erase1()
    {
        System.out.println("Erase a shape");
    }
}
class Trangle1 extends Shape1
{
    void draw1()
    {
        System.out.println("Draw a trangle");
    }
    void erase1()
    {
        System.out.println("Erase a trangle");
    }
}
class Square1 extends Shape1
{
    void draw1()
    {
        System.out.println("Draw a square");
    }
    void erase1()
    {
        System.out.println("Erase a square");
    }
}
class Circle1 extends Shape1
{
    void draw1()
    {
        System.out.println("Draw a circle");
    }
    void erase1()
    {
        System.out.println("Erase a circle");
    }
}
public class a36 
{
    public static void main(String[] args) 
    {
        Shape1 s = new Shape1();
        s.draw1();
        s.erase1();

        Shape1 t = new Trangle1();
        t.draw1();
        t.erase1();

        Shape1 u = new Circle1();
        u.draw1();
        u.erase1();

        Shape1 v = new Square1();
        v.draw1();
        v.erase1();
    }
}
