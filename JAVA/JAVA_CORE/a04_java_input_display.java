import java.io.DataInputStream;
import java.io.IOException;
class student
{
    private int empid;
    private String ename,post;
    private float salary;
    private char grade;
    student(String name,int id)
    {
        ename = name;
        empid = id;
    }
    public void setPost(String post)
    {
        this.post = post;
    }
    public void setSalary(float salary)
    {
        this.salary = salary;
    }
    public void setGrade(char grade)
    {
        this.grade = grade;
    }
    
    public void printDetails()
    {
        System.out.printf("Employee id: %d\nEmployee name: %s\nEmployee salary: %f\nEmployee post: %s\nEmlpoyee grade: %c\n",empid,ename,salary,post,grade);
    }
}

public class a1_java_input_display 
{
    public static void main(String[] args) throws IOException
    {
        int empid;
        String ename,post;
        float salary;
        char grade;
        DataInputStream ds = new DataInputStream(System.in);

        System.out.println("Enter Employee id:");
        empid = Integer.parseInt(ds.readLine());
        System.out.println("Enter Employee name:");
        ename = ds.readLine();
        System.out.println("Enter Employee post:");
        post = ds.readLine();
        System.out.println("Enter Employee salary:");
        salary = Float.parseFloat(ds.readLine());
        System.out.println("Enter Employee grade:");
        grade = (char)ds.read();

        student stud = new student(ename, empid);
        stud.setSalary(salary);
        stud.setPost(post);
        stud.setGrade(grade);
        
        stud.printDetails();

    }
}
