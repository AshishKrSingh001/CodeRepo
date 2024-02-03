// Write a program to give the example for method overriding concepts
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
class RightAngleTrangle extends Trangle1
{
    void draw1()
    {
        System.out.println("Draw a right angle trangle");
    }
    void erase1()
    {
        System.out.println("Erase a right angle trangle");
    }
}
public class a37 
{
    public static void main(String[] args) 
    {
        Shape1 s = new Shape1();
        s.draw1();
        s.erase1();
       Trangle1 t = new Trangle1();
        t.draw1();
        t.erase1();
        RightAngleTrangle u = new RightAngleTrangle();
        u.draw1();
        u.erase1();
    }
}
