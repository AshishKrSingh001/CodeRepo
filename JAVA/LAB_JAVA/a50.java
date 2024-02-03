// .Write a program to describe usage of throws clause. 

package LAB_JAVA;

import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;
import java.io.Console;

public class a50 
{
    
    public static void main(String[] args) throws IOException
    {
        byte b;
        short s;
        int a;
        long l;
        float f;
        double d;
        char ch;
        String str;
        DataInputStream ds = new DataInputStream(System.in);
        BufferedReader buf = new BufferedReader(new InputStreamReader(System.in));
        Console con = System.console();
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter four number: ");
        b=Byte.parseByte(ds.readLine());
        s=Short.parseShort(ds.readLine());
        a=Integer.parseInt(ds.readLine());
        l=Long.parseLong(ds.readLine());

        System.out.println("Enter two floating number: ");
        f=Float.parseFloat(con.readLine());
        d=Double.parseDouble(con.readLine());

        System.out.println("Enter a character: ");
        ch = (char)buf.read();

        System.out.println("Enter a string: ");
        str = sc.nextLine();

        System.out.println(a);
        System.out.println(b);
        System.out.println(ch);
        System.out.println(d);
        System.out.println(f);
        System.out.println(l);
        System.out.println(str);
        System.out.println(s);
        System.out.println(str);
    }
}
