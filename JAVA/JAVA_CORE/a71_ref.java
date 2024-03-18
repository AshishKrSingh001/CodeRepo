class A
{
    public void show()
    {
        System.out.println("class A");
    }
}
class D extends A
{
    public void show()
    {
        System.out.println("class D");
    }
}
class B extends A
{
    public void show()
    {
        System.out.println("class B");
    }
}
class C extends A
{
    public void show()
    {
        System.out.println("class C");
    }
}
public class a159_ref
{
    public void Display(A a)
    {
        a.show();
    }
    public static void main(String[] args) 
    {
        A a = new A();
        B b = new B();
        C c = new C();
        D d = new D();
        a159_ref obj = new a159_ref();
        obj.Display(a);
    }
}