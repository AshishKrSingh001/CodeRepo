// Write a program to demonstrate static variables, methods, and blocks.
package LAB_JAVA;

class Z
{
    static int a=100;
    int b=20;
    static
    {
        a*=2;
    }
    Z()
    {
        a++;
        b++;
    }
    static void decrement()
    {
        a--;
    }
    void decrement1()
    {
        a--;
        b--;
    }
    void show()
    {
        System.out.println("value of Static a: "+a);
        System.out.println("value of non-Static b: "+b);
    }
    
    
}
public class a35 
{
    public static void main(String[] args) 
    {
        Z z = new Z();
        z.show();
        z.decrement1();
        z.show();
        z.decrement();
        z.show();

        Z y = new Z();
        y.show();
        y.decrement1();
        y.show();
        y.decrement();
        y.show();
    }    
}
