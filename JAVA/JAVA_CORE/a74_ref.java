import java.util.Scanner;
class Person
{
    public void showDetails()
    {   
        System.out.println("In the Person class");
    }
}
class Employee extends Person
{
    public void showDetails()
    {
        System.out.println("In the Employee class");
    }
}
class Student extends Person
{
    public void showDetails()
    {
        System.out.println("In the Student class");
    }
}
class Method_Override1
{
    public static void printDetails(Person ref)
    {
        // if(ref instanceof Person)
        // {
        //     System.out.println("Person class Instance");
        // }
        if(ref instanceof Employee)
        {
            System.out.println("Employee class Instance");
            ref.showDetails();
        }
        if(ref instanceof Student)
        {       
            System.out.println("Student class Instance");
            ref.showDetails();
        }
    }
    public static void showMenu()
    {
        int option;
        Scanner sc = new Scanner(System.in);
        System.out.println("---------Menu---------");
        System.out.println("1. Employee");
        System.out.println("2. Student");
        System.out.print("\nChoose the option: ");

        option = sc.nextInt();

        switch(option)
        {
            case 1: Employee e=new Employee();
                printDetails(e);
                break;
            case 2: Student s=new Student();
                printDetails(s);
                break;
            default: System.out.println("Incorrect menu option");
                showMenu();

        }

    }
    public static void main(String []args)
    {
        showMenu();
        // Person P = new Person();
        // Person ref;
        // ref = P;
        // printDetails(ref);
        
        // Employee E = new Employee();
        // Student S = new Student();
        
        
        // ref.showDetails(); // calls the showDetails method of the Person
        // ref = E;
        // ref.showDetails(); // calls the showDetails method of the Employee
        // ref = S;
        // ref.showDetails();// calls the showDetails method of the Student
    }
}