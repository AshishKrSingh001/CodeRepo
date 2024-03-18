class abc
{
    int a;

    public int getA() {
        return a;
    }

    public void setA(int c) {
        this.a = c;
    }
    abc()
    {
        System.out.println("a");
    }
    abc(int x)
    {
        System.out.println(x);
    }
}
class abcd extends abc
{
    int b;

    public int getA() {
        return b;
    }

    public void setA(int c) {
        this.b = c;
    }
    abcd(int a,int b)
    {
        super(a);
        System.out.println(b);
    }
    abcd()
    {
        System.out.println("b");
    }
}
public class a93_super_this
{
    public static void main(String[] args)
    {
//        abc ab = new abc();
//        ab.setA(5);
//        System.out.println(ab.getA());
//        abcd a = new abcd();
//        a.setA(6);
//        System.out.println(a.getA());

        abc ab = new abc(5);
//        ab.setA(5);
//        System.out.println(ab.getA());
        abcd a = new abcd(5,6);
//        a.setA(6);
//        System.out.println(a.getA());
    }
}
