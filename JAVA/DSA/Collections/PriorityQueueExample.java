import java.util.*;
class Teacher implements Comparable<Teacher>{
    String name;
    int id;
    public Teacher(String name, int id){
        this.name = name;
        this.id = id;
    }
    public String toString(){
        return "Student name: "+this.name;
    }
    public int compareTo(Teacher that){
        return that.id-this.id;
    }

    @Override
    public boolean equals(Object obj) {
        if(obj instanceof Teacher){
            Teacher that = (Teacher)obj;
            if((that.id == this.id) && ((that.name.compareTo(this.name)) == 0))
            return true;
        }
        return false;
    }
}
public class PriorityQueueExample{
    public static void main(String[] args){
        // Min Proirity
        // PriorityQueue<Integer>minpq = new PriorityQueue<>();
        // minpq.offer(10);
        // minpq.offer(20);
        // minpq.offer(30);
        // minpq.offer(40);
        // minpq.offer(50);
        // minpq.offer(70);
        // System.out.println(minpq);
        // System.out.println("Min Priority Queue Peek() : "+minpq.peek());
        // System.out.println("Min Priority Queue poll() : "+minpq.poll());
        // System.out.println("Min Priority Queue Peek() : "+minpq.peek());

        // // Max Priority
        // PriorityQueue<Integer>maxpq = new PriorityQueue<>(Collections.reverseOrder());
        // maxpq.offer(10);
        // maxpq.offer(20);
        // maxpq.offer(30);
        // maxpq.offer(40);
        // maxpq.offer(50);
        // maxpq.offer(70);
        // System.out.println(maxpq);
        // System.out.println("Max Priority Queue Peek() : "+maxpq.peek());
        // System.out.println("Max Priority Queue poll() : "+maxpq.poll());
        // System.out.println("Max Priority Queue Peek() : "+maxpq.peek());

        PriorityQueue<Teacher>minTeacherpq = new PriorityQueue<>();
        Teacher t = new Teacher("Ashish", 101);
        minTeacherpq.offer(t);
        minTeacherpq.offer(new Teacher("Anish", 102));
        minTeacherpq.offer(new Teacher("Abhishek", 103));
        minTeacherpq.offer(new Teacher("Pursottam", 104));
        minTeacherpq.offer(new Teacher("Vijay", 105));
        System.out.println(minTeacherpq);
        System.out.println(minTeacherpq.contains(t));
        System.out.println(minTeacherpq.contains(new Teacher("Pursottam", 104)));
        System.out.println(minTeacherpq.contains(new Teacher("Vija", 105)));
    }    
}
