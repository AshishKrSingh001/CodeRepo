class A
{
    A()
    {
        System.out.println("Class A constructor:");
    }
}
class B extends A
{
    B()
    {
        System.out.println("Class B contructor:");
    }
}
class C extends B
{
    C()
    {
        System.out.println("Class C contructor:");
    }
}
class D extends C
{
    D()
    {
        System.out.println("Class D contructor:");
    }
}
class E extends D
{
    E()
    {
        System.out.println("Class E contructor:");
    }
}
class a162_constructor
{
    public static void main(String[] args) 
    {
        E e = new E();    
    }    
}
