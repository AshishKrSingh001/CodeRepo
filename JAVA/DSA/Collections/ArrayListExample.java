import java.util.*;
public class ArrayListExample 
{
    public static void main(String[] args) 
    {
        System.out.println("ArrayList Example");
        List<Integer>list = new ArrayList<>();
        list.add(10);
        list.add(20);
        list.add(100);
        list.add(1);
        list.add(50);
        list.add(0,0);
        list.add(70);
        System.out.println(list);
        list.remove(Integer.valueOf(10));
        System.out.println(list);
        list.remove(Integer.valueOf(0));
        System.out.println(list);
        System.out.println(list.contains(100));
        System.out.println(list.get(3));
        System.out.println(list.set(3,1000));
        System.out.println(list.get(3));
        System.out.println(list);
        Collections.reverse(list);
        // list.sort(new Comparator<Integer>() {
        //     public int compare(Integer A, Integer B)
        //     {
        //         return A-B;
        //     }
        // });
        // System.out.println(list);
        // list.sort(new Comparator<Integer>() {
        //     public int compare(Integer A, Integer B)
        //     {
        //         return B-A;
        //     }
        // });
        System.out.println(list);



        // List<Student>list1 = new ArrayList<>();
        // list1.add(new Student(132, "Ashish"));
        // list1.add(new Student(101, "Ashish"));
        // list1.add(new Student(102, "Ayush"));
        // list1.add(new Student(131, "Richa"));
        // list1.add(new Student(125, "Aman"));
        // list1.add(new Student(114, "Rohit"));
        // list1.add(new Student(103, "Ramesh"));
        // list1.add(new Student(111, "Ashish"));
        // list1.add(new Student(121, "Ramesh"));

        // Iterator<Integer> itr = list.iterator();
       // ListIterator<Integer> itr1 = list.listIterator();
        // System.out.println("******************************\nMy-list");
        // while(itr.hasNext())
        // {
        //     System.out.println(itr.next());
        // }
        // System.out.println("******************************");
        // System.out.println("******************************\nMy-list");
        // while(itr1.hasPrevious())
        // {
        //     System.out.println(itr1.previous());
        // }
        // System.out.println("******************************");
        

        // System.out.println(list1);
        // list1.sort(new Comparator<Student>() {
        //     public int compare(Student A, Student B)
        //     {
        //         int res = A.name.compareTo(B.name);
        //         return(res==0)?(A.rollNo-B.rollNo):res;
        //     }
        // });
        // System.out.println(list1);

    }   
}
class Student
{
    int rollNo;
    String name;

    public Student(int rollNo, String name) 
    {
        this.rollNo = rollNo;
        this.name = name;
    }
    public String toString()
    {
        return name + "(" + rollNo +")";
    }
}
