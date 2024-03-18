class c1
{
   public int x=25;
   private int y=26;
   protected int z=27;
   int a=10;
   public void meth1()
   {
       System.out.println("Public "+x);
       System.out.println("Private "+y);
       System.out.println("Protected "+z);
       System.out.println("Default "+a);
   }
}
class c2 extends c1
{
    public void meth2()
    {
        System.out.println("Public "+x);
        //System.out.println("Private "+y);
        System.out.println("Protected "+z);
        System.out.println("Default "+a);
    }
}
//class c3
//{
//
//}
public class a141_Access_modifiers
{
    public static void main(String[] args)
    {
//        c1 c = new c1();
//        c.meth1();
//        System.out.println("Public "+c.x);
//        //System.out.println("Private "+c.y);
//        System.out.println("Protected "+c.z);
//        System.out.println("Default "+c.a);

        c2 cc = new c2();
        cc.meth2();
    }
}
