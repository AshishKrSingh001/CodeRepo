interface sampleInterface
{
    void method1();
    void method2();
}
interface childOfInterface  extends sampleInterface
{
    void method3();
    void method4();
}
class MySampleClass implements childOfInterface
{
    public void method1()
    {
        System.out.println("method1");
    }
    public void method2()
    {
        System.out.println("method2");
    }
    public void method3()
    {
        System.out.println("method3");
    }
    public void method4()
    {
        System.out.println("method4");
    }
}
public class a124_inheritance_interfaces
{
    public static void main(String[] args)
    {
        MySampleClass msc = new MySampleClass();
        msc.method1();
        msc.method2();
        msc.method3();
        msc.method4();
    }
}
