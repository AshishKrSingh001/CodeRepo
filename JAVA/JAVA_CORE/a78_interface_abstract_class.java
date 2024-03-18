import java.util.Scanner;

interface Display
{
    void Enter_marks();
    void display_result();
}

abstract class Cimage
{
    String name;
    int id;
    int total_marks;
    float obtained_marks;
    float sub_marks[][];
    String sub_name[][];
    Scanner sc = new Scanner(System.in);
    Cimage()
    {
        System.out.println("Enter your name: ");
        name=sc.nextLine();
        System.out.println("Enter your Id: ");
        id=sc.nextInt();
    }
}
class BCA extends Cimage implements Display
{
    byte no_of_sub;
    byte sem;
    BCA()
    {
        super();
        System.out.println("Enter semester & number of subject");
        sem=sc.nextByte();
        no_of_sub=sc.nextByte();
        sub_marks=new float[sem][no_of_sub];
        sub_name=new String[sem][no_of_sub];
    }
    public void Enter_marks()
    {
        for(int i=0;i<sem;i++)
        {
            System.out.println("Enter semester- "+(i+1)+"Subject name & marks\nSubject name\tmarks:");
            for(int j=0;j<no_of_sub;j++)
            {
                sub_name[i][j]=sc.next();
                sub_marks[i][j]=sc.nextFloat();
            }
        }
    }
    public void display_result()
    {
        System.out.println("\t\t\tCIMAGE PROFESSIONAL COLLEGE, PATNA");
        System.out.println("*****************************************************************************");

        System.out.println("\nName: "+name+"\nId: "+id);
        for(int i=0;i<sem;i++)
        {
            System.out.println("Semester_"+(1+i)+"\nSubject name\tTotal Marks\tPassing marks\tObtained Marks");
            for(int j=0;j<no_of_sub;j++)
            {
                System.out.println(sub_name[i][j]+"\t\t"+"100\t\t33\t\t"+sub_marks[i][j]+"\t\t");
            }
        }
    }
}

class a164_interface_abstract_class 
{
    public static void main(String[] args) 
    {
        BCA a = new BCA();
        a.Enter_marks();
        a.display_result();
    }    
}
