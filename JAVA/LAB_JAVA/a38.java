// .Write a program to give the example for ‘super’ keyword.
package LAB_JAVA;
class P
{
    P()
    {
        System.out.println("This is Parent class Constructor");
    }
    void method()
    {
        System.out.println("This is Parent class Method");
    }
}
class R extends P
{
    R()
    {
        System.out.println("This is child class Constructor");
    }
    void method()
    {
        super.method();
        System.out.println("This is child class Method");
    }
}
public class a38 
{
    public static void main(String[] args) 
    {
        System.out.println("Parent");
        P p = new P();
        p.method();
        System.out.println("\n\nChild");
        R q = new R();
        q.method();
    }
}
