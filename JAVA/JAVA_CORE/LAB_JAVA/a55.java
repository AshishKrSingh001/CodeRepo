// Write a Java Program to implement Wrapper classes and their methods
package LAB_JAVA;

import java.util.Scanner;

public class a55
{
    private byte a=10;
    private Byte aa = new Byte(a);
    private short b=100;
    private Short bb = new Short(b);
    private int c=1000;
    private Integer cc = new Integer(c) ;
    private long d=10000;
    private Long dd = new Long(d);
    private float e=100.111f;
    private Float ee = new Float(e);
    private double f=100.11111111111;
    private Double ff = new Double(f);
    private char g='a';
    private Character gg = new Character(g);
    private boolean h=false;
    private Boolean hh = new Boolean(h);
    public static void main(String[] args) 
    {
        a55 obj = new a55();
        System.out.println("byte: "+obj.aa+"\nshort: "+obj.bb+"\nint: "+obj.cc+"\nlong: "+obj.dd+"\nfloat: "+obj.ee+"\ndouble: "+obj.ff+"\nchar: "+obj.gg+"\nboolean: "+obj.hh);
    }
}

