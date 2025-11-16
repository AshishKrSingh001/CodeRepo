//Consider the following code to write the data to a file using the FileoutputStream class:
import java.io.*;
import java.util.Scanner;;
public class a03_output_FileOutputStream
{
    public static void main(String[] args) throws IOException
    {
        boolean bool;
        long pos;
        String s = "Ashish is a good boy\n";
		//new String();
        //Scanner sc = new Scanner(System.in);
        //s=sc.nextLine();
        byte buf[] = s.getBytes();
        try (FileOutputStream fos = new FileOutputStream("D:\\programming\\Java\\file\\z.txt",true))
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