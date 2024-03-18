import java.util.Scanner;

class Student
{
    int id;
    String name;
    public void PrintDetails()
    {
        System.out.println("My name is "+name+"\nAnd my id is "+id);
    }
}
public class a71_oops_basics
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        Student Ashish = new Student();
        Ashish.id = 13089;
        Ashish.name = "Ashish";
//        System.out.println(Ashish.id);
//        System.out.println(Ashish.name);
        Ashish.PrintDetails();
    }
}
