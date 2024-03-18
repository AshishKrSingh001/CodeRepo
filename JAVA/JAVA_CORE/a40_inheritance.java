class Base
{
    int x;

    public int getX() {
        return x;
    }
    public void setX(int x) {
        this.x = x;
    }
}
class Derived extends Base
{
    int y;

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

}
public class a91_inheritance
{
    public static void main(String[] args)
    {
        //Base class is super class
        Base bas = new Base();
        bas.setX(11);
        System.out.println("Base class "+bas.getX());

        //Derived class is sub class which is derived by Base class;
        Derived der = new Derived();
        der.setX(10);
        der.setY(20);
        System.out.println("Derives class "+der.getX());
        System.out.println("Derived class "+der.getY());
    }
}
