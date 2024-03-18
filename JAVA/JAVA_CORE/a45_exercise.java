import java.awt.*;

class circle
{
    int radius;

    public int getRadius() {
        return radius;
    }

    public void setRadius(int radius) {
        this.radius = radius;
    }
    public double areaOfCircle()
    {
        return Math.pow(getRadius(),2)*Math.PI;
    }

}
class cylandrical extends circle
{
    int height;

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }
    public double volumeOfCylinder()
    {
        return 2*getHeight()*areaOfCircle();
    }
}
class rectangle
{
    int length,breadth;

    public int getLength() {
        return length;
    }

    public void setLenght(int length) {
        this.length = length;
    }

    public int getBreadth() {
        return breadth;
    }

    public void setBreadth(int breadth) {
        this.breadth = breadth;
    }
    public int areaOfRectangle()
    {
        return getBreadth()*getLength();
    }
}
class cubiod extends rectangle
{
    int height;

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }
    public int volumeOfCubiod()
    {
        return getHeight()*areaOfRectangle();
    }
}
public class a112_exercise
{
    public static void main(String[] args)
    {
        cylandrical c = new cylandrical();
        c.setHeight(10);
        c.setRadius(20);
        System.out.println("Area of Circle "+c.areaOfCircle());
        System.out.println("Volume of Circle "+c.volumeOfCylinder());

        cubiod cu = new cubiod();
        cu.setBreadth(10);
        cu.setLenght(20);
        cu.setHeight(30);
        System.out.println("Area of Rectangle "+cu.areaOfRectangle());
        System.out.println("Volume of Cubiod "+cu.volumeOfCubiod());
    }
}
