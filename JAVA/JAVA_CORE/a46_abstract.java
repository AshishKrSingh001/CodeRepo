abstract class parent
{
    public parent()
    {
        System.out.println("Mai contructor hoon");
    }
    public void hello()
    {
        System.out.println("hello");
    }
    abstract public void greet();
    abstract public void greet2();
}
class child extends parent
{
    @Override
    public void greet()
    {
        System.out.println("Good Morning");
    }
    @Override
    public void greet2()
    {
        System.out.println("Good Evening");
    }
}
abstract class childofchild extends parent
{
    public void th()
    {
        System.out.println("I'm Good");
    }
}
public class a121_abstract
{
    public static void main(String[] args)
    {
        //parent p = new parent();//  not allowed
        child c = new child(); //  allowed
        c.greet();
        c.greet2();
        parent cc = new child();
        cc.greet();
        cc.greet2();
        //childofchild ch = new childofchild();//  not allowed


    }
}
