/*
 *  Write a program to create a room class, the attributes of this class is
    Roomno , roomtype , roomarea and ACmachine. In this class the member
    functions are setdata and displaydata
 */
package LAB_JAVA;

import java.util.Scanner;

class Room
{
    int roomno,ACmachine;
    String roomtype;
    Scanner sc = new Scanner(System.in);
    void setdata()
    {
        System.out.println("Enter room no");
        roomno = sc.nextInt();
        sc.nextLine();
        System.out.println("Enter room type");
        roomtype = sc.nextLine();
        System.out.println("Enter ACmachine");
        ACmachine = sc.nextInt();
    }
    void displaydata()
    {
        System.out.println("Room no: "+roomno+"\nRoom type: "+roomtype+"\nAC machine: "+ACmachine);
    }
}
public class a31 
{
    public static void main(String[] args) 
    {
        Room r = new Room();
        r.setdata();
        r.displaydata();   
    }
}
