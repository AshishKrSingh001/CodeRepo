import java.util.Scanner;
import java.io.BufferedInputStream;
import java.io.DataInputStream;

class Strings
{
    String str;
    Strings(String str)
    {
        this.str = str;
    }
    public void Display()
    {
        System.out.println("str: "+str);
        
        System.out.println("str.length(): "+str.length());
        System.out.print("str.charAt(i):  ");
        for(int i=0;i<str.length();i++)
        {
            System.out.print("\t"+str.charAt(i));
        }
        System.out.println("\nstr.equals(Ashish): "+str.equals("Ashish"));
        System.out.println("str.compareTo(Ashish): "+str.compareTo("Ashish"));
        System.out.println("str.startsWith(a): "+str.startsWith("a"));
        System.out.println("str.endsWith(z): "+str.endsWith("z"));
        System.out.println("str.indexOf(a, 1): "+str.indexOf("a", 1));
        System.out.println("str.lastIndexOf(a, 4): "+str.lastIndexOf("a", 4));
        System.out.println("str.substring(1, 3)): "+str.substring(1, 3));
        System.out.println("str.concat(abc): "+str.concat("abc"));
        System.out.println("str.replace(a, z): "+str.replace("a", "z"));
        System.out.println("str.toUpperCase(): "+str.toUpperCase());
        System.out.println("str.toLowerCase(): "+str.toLowerCase());
        System.out.print("str.toCharArray(): ");
        char[] ch=str.toCharArray();
        for(int i=0;i<str.length();i++)
        {
            System.out.print("\t"+ch[i]);
        }
        System.out.println("\nstr.equalsIgnoreCase(Ashish): "+str.equalsIgnoreCase("Ashish"));
        int a=10;
        String st = "a";
        System.out.println("str.valueOf('a'): "+str.valueOf(st));



    }
}



public class a156_String 
{
    public static void main(String[] args) 
    {
        Strings st = new Strings("ashish");
        st.Display();    
    }    
}
