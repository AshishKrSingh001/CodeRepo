import java.util.Scanner;
class Employee
{
    int id,salary,age;
    String name,post;
    public void Input_Details()
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter your Name:");
        name = sc.next();
        System.out.println("Enter your Id:");
        id = sc.nextInt();
        System.out.println("Enter your Post:");
        post = sc.next();
        System.out.println("Enter your Age:");
        age = sc.nextInt();
        System.out.println("Enter your Salary:");
        salary = sc.nextInt();
    }
    public void Display_Details()
    {
        System.out.println(name);
        System.out.printf("Your Name is %s\nYour Id is %d\nYour Post is %s\nyour Age is %d\nYour Salary is %d\n",name,id,post,age,salary);
    }
}
public class a72_oops
{
    public static void main(String[] args)
    {
        Employee sn_01 = new Employee();
        sn_01.Input_Details();
        sn_01.Display_Details();
    }
}
