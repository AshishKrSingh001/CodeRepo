//Consider the following code to write the data to a file using the FileWriter class:
import java.io.FileWriter;
import java.io.IOException;
public class a04_output_FileWriter
{
    public static void main(String args[])
    {
        try (FileWriter f = new FileWriter("D:\\Files\\y.txt ",true))
        {
            String source = "This is FileWriter Program\n";
            char buffer[] = new char[source.length()];
			buffer[0]='A';
			
            source.getChars(0, source.length()+1, buffer, 1);
            f.write(buffer);
        }
        catch (IOException e)
        {
            System.out.println(e);
        }
    }
}
