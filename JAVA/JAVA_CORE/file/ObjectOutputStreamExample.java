import java.io.*;
class Employee implements Serializable {
 private int id;
 private String name;

 public int getId() {
  return id;
 }

 public void setId(int id) {
  this.id = id;
 }
 public String getName() {
  return name;
 }

 public void setName(String name) {
  this.name = name;
 }
}

public class ObjectOutputStreamExample {

 public static void main(String[] args) {
  final Employee employee = new Employee();
  employee.setId(101);
  employee.setName("Raju Upadhyay");
  try (final FileOutputStream fout = new FileOutputStream("employees.txt");
    final ObjectOutputStream out = new ObjectOutputStream(fout)) 
  {
   out.writeObject(employee);
   out.flush();
   System.out.println("success");
  } 
  catch (IOException e) 
  {
	  e.printStackTrace();
  }
 }
}
