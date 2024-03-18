//Consider the following code to write the data to a file using the FileoutputStream class:
import java.io.*;
class FileOutputStreamDemo
{
    public static void main(String[] args) throws IOException
    {
        boolean bool;
        long pos;
        String s = "This is a FileOutputStream Program";
        byte buf[] = s.getBytes();
        try (FileOutputStream fos = new FileOutputStream("D:\\Files\\file2.txt "))
        {
            for (int i = 0; i < buf.length; i++)
            {
                fos.write(buf[i]);
            }
        }
        catch (Exception e)
        {
            System.out.println(e);
        }
    } //end of main()
} //end of class