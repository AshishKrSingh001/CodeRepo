import java.io.DataInputStream;
import java.io.IOException;

class IllegalAgeException extends Exception
{
    IllegalAgeException(String msg)
    {
        super(msg);
    }
}

public class a148_throw_Exception 
{
    int age;
    DataInputStream ds = new DataInputStream(System.in);
    void input() throws IOException,IllegalAgeException
    {
        System.out.println("Enter your age: ");
        age = Integer.parseInt(ds.readLine());
        if(age<18)
        {
            IllegalAgeException ie = new IllegalAgeException("Not eligible for vote");
            throw ie;
        }
    }
    void validateAge()
    {
        if(age>=18)
        {
            System.out.println("Eligible for voting");
        }
    }
    public static void main(String[] args) 
    {
        a148_throw_Exception obj = new a148_throw_Exception();
        try
        {
            obj.input();
            obj.validateAge();
        }
        catch(IllegalAgeException e)
        {
            System.out.println(e.getMessage());
        }
        catch(IOException e)
        {}
        catch(NumberFormatException n)
        {
            System.out.println("Invalid Input "+n);
        }
    }
}
