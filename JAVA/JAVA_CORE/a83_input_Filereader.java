//Consider the following code to read the data from a file using the FileReader class:
import java.io.FileReader;
import java.io.IOException;
class FileReaderDemo {
    public static void main(String args[])
    {
        try (FileReader f = new FileReader("A.abc"))
        {
            char[] a = new char[1000];
            f.read(a);
            
            for (char c : a)
            {
                System.out.print(c);
            }
        }
        catch (IOException e)
        {
            System.out.println(e);
        }
    }
}
