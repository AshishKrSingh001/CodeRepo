interface sampleInterface1
{
    void method1();
    void method2();
}
interface sampleInterface2
{
    void method3();
    void method4();
}
class MySampleClass1 implements sampleInterface1,sampleInterface2
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
public class a125_polymorphism
{
    public static void main(String[] args)
    {
        sampleInterface1 msc1 = new MySampleClass1();// only Those method will be accessed which is in reference class(sampleInterface1) such as:
        msc1.method1();
        msc1.method2();

        sampleInterface2 msc2 = new MySampleClass1();// only Those method will be accessed which is in reference class(sampleInterface2) such as:
        msc2.method3();
        msc2.method4();
    }
}
