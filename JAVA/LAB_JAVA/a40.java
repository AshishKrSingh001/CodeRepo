/*  Write a program to create interface A in this interface we have two
    method meth1 and meth2. Implements this interface in another class
    named MyClass.
*/
package LAB_JAVA;
interface AA
{
    
    void meth1();
    void meth2();
}
class MyClass implements AA
{
    public void meth1()
    {
        System.out.println("This is method 1");
    }
    public void meth2()
    {
        System.out.println("This is method 2");
    }
}
public class a40 
{
    public static void main(String[] args) 
    {
        MyClass m = new MyClass();
        m.meth1();
        m.meth2();
    }
}
