//StringIndexOutOfRange
//InterrupedException
//NullPointException
//WAP in Java to input your name, After that print Each character in new line during 1:sec interval time.Implementation OF nested try block;


public class a146_Nested_try 
{
    public static void main(String[] args) 
    {
        String nm = "Ashish";
		String nm2 = null;
        int i;
        try
        {
            for(i=0;i<=nm.length();i++)
            {
                System.out.println(nm.charAt(i));
                try
                {
                    Thread.sleep(1000);
                }
                catch(InterruptedException a)
                {}
            }
        }
        catch(StringIndexOutOfBoundsException s)
        {
            System.out.println("Invalid index\n"+s);
        }
        catch(NullPointerException n)
        {
            System.out.println("Null value in the String\n"+n);
        }
        catch(Exception e)
        {
            System.out.println(e);
        }
        finally
        {
            System.out.println("Thanks");
        }
        
        
    }
}
