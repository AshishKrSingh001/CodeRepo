class base1
{
    base1()
    {
        System.out.println("Base");
    }
    base1(int a)
    {
        System.out.println("Base = "+a);
    }
}
class derived1 extends base1
{
    derived1()
    {
        System.out.println("Derived");
    }
    derived1(int a,int b)
    {
        super(a);
        System.out.println("Derived = "+b);
    }
}
class childOfderived extends derived1
{
    childOfderived()
    {
        System.out.println("Child of Derived");
    }
    childOfderived(int a,int b,int c)
    {
        super(a,b);
        System.out.println("Child of Derived = "+c);
    }
}
public class a92_inheritance_constructors
{
    public static void main(String[] args)
    {
//        base1 bas = new base1(10);
//        derived1 der = new derived1(10,20);
        childOfderived cod = new childOfderived(10,20,30);
//
//        base1 bas1 = new base1();
//        derived1 der1 = new derived1();
//        childOfderived cod1 = new childOfderived();
    }
}