import java.util.Scanner;

class Student1
{
    private int id;
    int age;
    private String name;

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
public class a81_AccessModifier
{
    public static void main(String[] args)
    {
        Student1 Ash = new Student1();
        Ash.age = 30;
       //Ash.id = 101;his statement can't be access because of private access specifier;
        Ash.setname("Ashish");
        System.out.println(Ash.getname());
        Ash.setid(101);
        System.out.println(Ash.getid());

    }
}
