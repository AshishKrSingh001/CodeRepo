interface Bicycle
{
    int a = 88;
    void applyBreak(int decrement);
    void speedUp(int increment);
}
interface blowHorn
{
    void blowHorn1();
    void blowHorn2();
}
class AvonCycle implements Bicycle,blowHorn
{
    void BlowHorn()
    {
        System.out.println("pee pee");
    }
    public void applyBreak(int decrement)
    {
        System.out.println("Apply Break");
    }
    public void speedUp(int increment)
    {
        System.out.println("Speed Up");
    }
    public void blowHorn1()
    {
        System.out.println("1 pee pee");
    }
    public void blowHorn2()
    {
        System.out.println("2 pee pee");
    }
}
public class a122_interface
{
    public static void main(String[] args)
    {
        Bicycle b = new AvonCycle();

        // You can create a properties in interface;
        System.out.println(b.a);
        // You can't modify the properties;
        //b.a = 10;//Not allowed

        b.applyBreak(1);
        b.speedUp(1);

        blowHorn bl = new AvonCycle();
        bl.blowHorn2();
        bl.blowHorn1();



    }
}
