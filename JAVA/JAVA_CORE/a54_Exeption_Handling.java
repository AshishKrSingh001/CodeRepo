import java.io.*;
class Arithmetic
{
    private double num1,add,sub,mult,div;
	private int num2;
    public void input()
    {
        try
        {
            DataInputStream ds = new DataInputStream(System.in);
            System.out.println("Enter first number:");
            num1 = Integer.parseInt(ds.readLine());
            
            System.out.println("Enter second number:");
            num2 = Integer.parseInt(ds.readLine());
        }
        catch(IOException e)
        {
            System.out.println(e);
        }
        
    }
    public void operation()
    {
        add = num1 + num2;
        sub = num1 - num2;
        mult = num1 * num2;
        div = num1 / num2;
    }
    public void display()
    {
        System.out.println("Addition: "+add+"\nSubtraction: "+sub+"\nMultiplication: "+mult+"\nDivison: "+div);
    }
    
 
}
public class a142_Exeption_Handling 
{
    static public void main(String[] args) 
    {
        try
        {
            Arithmetic arth = new Arithmetic();
            arth.input();
            arth.operation();
            arth.display();
        }
        catch(ArithmeticException n)
        {
            System.out.println("You are dividing by zero "+n);
        }
        catch(NumberFormatException n)
        {
            System.out.println("Invalid input "+n);
        }
        catch(Exception e)
        {
            System.out.println(e);
        }
    }   
}
