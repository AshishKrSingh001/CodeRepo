/*
 * Create an outer class with a function display, again create another class
    inside the outer class named inner with a function called display and call
    the two functions in the main class.
 */
package LAB_JAVA;

import LAB_JAVA.Outer.Inner;

class Outer
{
    void display()
    {
        System.out.println("This is Outer class's display");
    }
    class Inner
    {
        void display()
        {
            System.out.println("This is Inner class's display");
        }
    }
}
public class a43 
{
    public static void main(String[] args) 
    {
        Outer o = new Outer();
        o.display();

        Outer.Inner i = o.new Inner();
        i.display();

    }    
}
