/*
Operator                                                                                    Associativity   Precedence
Function call,Array Subscript,Dot(Structure),Arrow(structure)                               Left to Right       14
Logical not(!),Increment(++),Decrement(--),Address-of(&),Indirection(*),typecast,sizeof     Right to Left       13
Multiplication(*),Division(/),Modulus(%)                                                    Left to Right       12
Addition(+),Subtraction(-)                                                                  Left to Right       11
Left-shift,Right-shift                                                                      Left to Right       10
Less than,Greater than,Less than or equal to,Greater than or equal to,                      Left to Right       8
Equal to,Not equal to                                                                       Left to Right       8
Bitwise and,Bitwise or,Bitwise not                                                          Left to Right       7

*/

import java.util.Scanner;
public class a12_operator_associativity_precedence
{
    public static void main(String[] args)
    {
        // WAP to int three coefficient of any equation and find the root
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter three coefficient");
        float a = sc.nextFloat();
        float b = sc.nextFloat();
        float c = sc.nextFloat();
        double d = (-b+(Math.sqrt(b*b-4*a*c)))/2;
        double e = (-b-(Math.sqrt(b*b-4*a*c)))/2;
        System.out.println("Root=\n"+d+"\n"+e);
    }
}
