class One
{
    public void greet()
    {
        System.out.println("Good morning");
    }
    public void name()
    {
        System.out.println("My name is Java in Class 1");
    }
}
class Two extends One
{
    public void greet2()
    {
        System.out.println("Welcome");
    }
    public void name()
    {
        System.out.println("My name is Java in Class 2");
    }
}
public class a101_dynamic_method_dispatch
{
    public static void main(String[] args)
    {
        One obj = new Two();
        obj.name();//method name of class will override the method name of class one
        obj.greet();
        //obj.greet2(); //not allowed

    }
}
