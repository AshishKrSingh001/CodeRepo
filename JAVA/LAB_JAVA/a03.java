/*
 * Write a program to give the examples of operators.
    a. Increment and decrement operators.
    b. Bitwise Complement Operator.
    c. Arithmetic operator.
    d. Relational Operator.
    e. Bitwise operator.
    f. Conditional Operator.
 */

package LAB_JAVA;

import java.io.DataInputStream;
import java.io.IOException;
class Operator
{
    int a,b;
    Operator() throws IOException
    {
        System.out.println("Enter two number: ");
        DataInputStream ds = new DataInputStream(System.in);
        a = Integer.parseInt(ds.readLine());
        b = Integer.parseInt(ds.readLine());
    }
    void Increment()
    {
        System.out.println("Incerment of a: "+(++a));
        System.out.println("Incerment of b: "+(++b));
    }
    void Decrement()
    {
        System.out.println("Decerment of a: "+(--a));
        System.out.println("Decerment of b: "+(--b));
    }
    void Bitwise()
    {
        System.out.println("a & b: "+(a & b));
        System.out.println("a | b: "+(a | b));
        System.out.println("a ^ b: "+(a ^ b));
        System.out.println("~a: "+(~a));
        System.out.println("~b: "+(~b));
    }
    void Arithmetic()
    {
        System.out.println("Addition: "+(a+b));
        System.out.println("Subtraction: "+(a-b));
        System.out.println("Multiplication: "+(a*b));
        System.out.println("Division: "+(a/b));
        System.out.println("Modulus: "+(a%b));
    }
    void Relational()
    {
        System.out.println("a == b: "+(a == b));
        System.out.println("a < b: "+(a < b));
        System.out.println("a > b: "+(a > b));
        System.out.println("a >= b: "+(a >= b));
        System.out.println("a <= b: "+(a <= b));
    }
    void Conditional()
    {
        System.out.println("((a>10)&&(b<10)): "+((a>10)&&(b<10)));
        System.out.println("((a>10)||(b<10)): "+((a>10)||(b<10)));
        System.out.println("a != b: "+(a != b));
    }
    public static void main(String[] args)
    {
        try
        {
            Operator op = new Operator();
            op.Arithmetic();
            op.Bitwise();
            op.Conditional();
            op.Decrement();
            op.Increment();
            op.Relational();
        }
        catch(NumberFormatException e)
        {
            System.out.println("Invalid Input");
        }
        catch(IOException e)
        {}
    }
}
