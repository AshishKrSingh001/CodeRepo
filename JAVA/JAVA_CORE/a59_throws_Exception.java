import java.io.DataInputStream;
import java.io.IOException;
class login
{
    private String username="cimage.in",user,password="aku.cimage.in",pass;
    login() throws IOException,InterruptedException
    {
        DataInputStream ds = new DataInputStream(System.in);
        System.out.println("Enter your Username:");
        user = ds.readLine();
        System.out.println("Validating....");
        Thread.sleep(3000);
        if(user.equals(username)==true)
        {
            System.out.println("Enter your Password:");
            pass = ds.readLine();
            System.out.println("Validating....");
            Thread.sleep(3000);
            if(pass.equals(password)==true)
            {
                System.out.println("Login successfully");
            }
            else
            {
                System.out.println("Invalid password");
            }
        }
        else
        {
            System.out.println("Invalid username");
        }
    }
}
public class a147_throws_Exception
{
    public static void main(String[] args) throws IOException,InterruptedException
    {
        login log = new login();
    }
}