//Consider the following code to read the data from a file using the FileInputStream class:
import java.io.FileInputStream;
import java.io.IOException;
public class a01_input_FileInputStream
{
    public static void main(String[] args)
    {
        int i; char c;
        try (FileInputStream f = new FileInputStream("D:/programming/Java/file/emp.data"))
        {
            while ((i = f.read()) != -1)
            {
                c = (char) i;
                System.out.print(c);
                //System.out.println(i);
            }
        }
        catch (IOException ex)
        {
            System.out.println(ex);
        }
    }
}