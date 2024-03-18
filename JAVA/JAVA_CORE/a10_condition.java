import java.util.Scanner;
public class a31_condition
{
    public static void main(String[] args)
    {
       Scanner sc = new Scanner(System.in);
        System.out.println("Enter consumed unit of this month:");
       int unit = sc.nextInt();
       float bill;
       if(unit>=0 && unit<=100)
       {
           bill = 0;
       }
       else if(unit>100 && unit<=250)
       {
           unit = unit-100;
           bill = unit*8.5f;
       }
       else
       {
           unit = unit-250;
           bill = unit*10 + 150*8.5f;
       }
        System.out.printf("your bill amount is %f",bill);


    }
}
