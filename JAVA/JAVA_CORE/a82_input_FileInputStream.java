//Consider the following code to read the data from a file using the FileInputStream class:
import java.io.FileInputStream;
import java.io.IOException;
class FileInputStreamDemo
{
    public static void main(String[] args)
    {
        int i; char c;
        try (FileInputStream f = new FileInputStream("D:\\programming\\Java\\a168_input_FileInputStream.java"))
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