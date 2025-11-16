// Write a program for creation of user defined exception. 
package LAB_JAVA;

import java.util.Scanner;

class InvalidUserNameException extends Exception
{
    InvalidUserNameException(String msg)
    {
        super(msg);
    }
}
class InvalidPasswordException extends Exception
{
    InvalidPasswordException(String msg)
    {
        super(msg);
    }
}
class Login
{
    private String password,username;
    private static String Uname,passwd;
    Scanner scan = new Scanner(System.in);
    Login()
    {
        //Uname="ashish@cimage.in";
        passwd="aaa";
    }
    void input() throws InvalidPasswordException,InvalidUserNameException
    {
        System.out.println("Enter your Username: ");
        username=scan.nextLine();
        if(!(username.equals(Uname)))
        {
            throw new InvalidPasswordException("Invalid Username");
        }
        else
        {
            System.out.println("Enter Password");
            password=scan.nextLine();
            if(!(password.equals(passwd)))
            {
                InvalidPasswordException e = new InvalidPasswordException("Invalid Password");
                throw e;
            }
        }
    }
    void output()
    {
        System.out.println("Login Successfully");
    }
}
public class a51 
{
    public static void main(String[] args) 
    {
        Login log = new Login();
        try
        {
            log.input();
            log.output(); 
        }
        catch(InvalidPasswordException e)
        {
            System.out.println(e);
        }
        catch(InvalidUserNameException e)
        {
            System.out.println(e);
        }
        finally
        {
            System.out.println("Thanks");
        }
           
    }
}
