import java.util.*;
class MyStudent implements Comparable<MyStudent>{
    int id;
    String name;
    public MyStudent(int id, String name){
        this.id = id;
        this.name = name;
    }
    @Override
    public String toString(){
        return this.name + "->" + this.id;
    }
    public int compareTo(MyStudent that){
        if(this.id == that.id){
            return (this.name).compareTo(that.name);
        }else{
            return this.id - that.id;
        }
    }
}
public class CompareObjects{
    public static void main(String[] args){
        ArrayList<MyStudent>list = new ArrayList<>();
        
        list.add(new MyStudent(105, "Pursottam Jha"));
        list.add(new MyStudent(106, "Suraj Kumar"));
        list.add(new MyStudent(107, "Utkarsh Mishra"));
        list.add(new MyStudent(108, "Sumit Kumar"));
        list.add(new MyStudent(103, "Vijay Mandal"));
        list.add(new MyStudent(101, "Ashish Kumar Singh"));
        list.add(new MyStudent(102, "Abhishek Kumar"));
        list.add(new MyStudent(104, "Himanshu Kumar Singh"));
        list.add(new MyStudent(103, "Saurabh Gupta"));
        list.add(new MyStudent(101, "Anish Kumar Roy"));
        list.add(new MyStudent(102, "Ashish Acharya"));
        list.add(new MyStudent(104, "Prince"));
        // Comparator<MyStudent>cmp = new Comparator<MyStudent>() {
        //     public int compare(MyStudent s1, MyStudent s2){
        //         if(s1.id == s2.id){
        //             return (s1.name).compareTo(s2.name);
        //         }else{
        //             return s1.id - s2.id;
        //         }
        //     }
        // };
        // Collections.sort(list, cmp);
        Collections.sort(list);
        for(MyStudent stud:list){
            System.out.println(stud);
        }
    }    
}
