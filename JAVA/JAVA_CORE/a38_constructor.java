import java.util.Scanner;
class Employeee
{
    private int id;
    private String name;
    public Employeee()
    {
        id = 101;
        name = "Ashish";
    }
    public Employeee(int myid,String myname)
    {
        id = myid;
        name = myname;
    }
    public void setname(String s)
    {
        this.name = s;
    }
    public String getname()
    {
        return name;
    }
    public void setid(int i)
    {
        this.id = i;
    }
    public int getid()
    {
        return id;
    }

}
public class a82_constructor
{
    public static void main(String[] args)
    {
        Employeee Ash = new Employeee(101,"Ashish");
        Employeee ash = new Employeee(101,"Ashish");
        System.out.println(Ash.getid());
        System.out.println(Ash.getname());
        System.out.println(ash.getid());
        System.out.println(ash.getname());
    }
}
