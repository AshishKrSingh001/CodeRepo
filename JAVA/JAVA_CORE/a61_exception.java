/*WAP in java to create two user defined exceptions as named "NegativeLengthException" & "NegativeBreadthException".
these exception must be raised if either length or breadth be negative.Again create a class as named rectangle to input
length and breadth after that find Area and Perimeter of rectangle.*/

import java.io.*;

class NegativeLengthException extends Exception
{
    NegativeLengthException(String msg)
    {
        super(msg);
    }
}
class NegativeBreadthException extends Exception
{
    NegativeBreadthException(String msg)
    {
        super(msg);
    }
}

class Rectangle
{
    private int l,b,area,peri;

    InputStreamReader isr  = new InputStreamReader(System.in);
    BufferedReader br = new BufferedReader(isr);
    //BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    void getInput() throws IOException,NegativeLengthException,NegativeBreadthException
    {
        System.out.println("Enter lenght and breadth:");
        l = Integer.parseInt(br.readLine());
        b = Integer.parseInt(br.readLine());
        if(l<0)
        {
            throw new NegativeLengthException("Length can't be negative!");
        }
        if(b<0)
        {
            throw new NegativeLengthException("Breadth can't be negative!");
        }
    }
    void findArea()
    {
        area = l*b;
        System.out.println("Area of Rectangle: "+area);
    }
    void findPeri()
    {
        peri = 2*(l+b);
        System.out.println("Perimeter of Rectangle: "+peri);
    }
}
public class a149_exception
{
    public static void main(String[] args) 
    {
        Rectangle rec = new Rectangle();
        try
        {
            rec.getInput();
            rec.findArea();
            rec.findPeri();
        }
        catch(NumberFormatException n)
        {
            System.out.println("Invalid input! "+n);
        }
        catch(NegativeBreadthException n)
        {
            System.out.println(n);
        }
        catch(NegativeLengthException n)
        {
            System.out.println(n);
        }
        catch(IOException e)
        {}
        catch(Exception e)
        {
            System.out.println(e);
        }
        
        
    }
}