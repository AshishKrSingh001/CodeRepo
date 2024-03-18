import java.io.*;
interface ILogin
{
    public static final String username= "ashish@123";
    public static final String password= "@ashish";

    public abstract boolean verifyUsername();
    public abstract boolean verifyPassword();

}
abstract class ALogin implements ILogin
{
    String usernm;
    String passwd = new String();
    public boolean verifyUsername()
    {
        if(username.equals(usernm))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public boolean verifyPassword()
    {
        if(password.equals(passwd))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    abstract void login();
}
class CLogin extends ALogin
{
    CLogin()
    {
        usernm = new String();
        passwd = new String();
    }
    void login()
    {
        try
        {
            DataInputStream ds = new DataInputStream(System.in);
            System.out.println("Enter Username: ");
            usernm = ds.readLine();
            if (verifyUsername())
            {
                System.out.println("Enter Password: ");
                passwd = ds.readLine();
                if(verifyPassword())
                {
                    System.out.println("Login successfully");
                }
                else
                {
                    System.out.println("Invalid Password");
                }
            }
            else
            {
                System.out.println("Invalid Username");
            }
            
            
        }
        catch(IOException e)
        {}
    }
}
class MLogin
{
    public static void main(String[] args) 
    {
        CLogin c = new CLogin();
        c.login();
    }
}