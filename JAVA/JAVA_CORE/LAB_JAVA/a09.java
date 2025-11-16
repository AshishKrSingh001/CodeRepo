/*
 * Write a program to calculate the following
    a. Find the length of array.
    b. Demonstrate a one-dimensional array.
    c. Demonstrate a two-dimensional array.
    d. Demonstrate a multi-dimensional array.
 */
package LAB_JAVA;

import java.util.Scanner;

class oneD
{
    int a[];
    int n;
    Scanner s=new Scanner(System.in);
    oneD()
    {
        System.out.println("Enter size of array ");
        
        n=s.nextInt();
        a=new int[n];
        
    }
    void input()

    {
        System.out.println("Enter "+n+" number :");
        for(int i=0;i<n;i++)
        {
            a[i]=s.nextInt();
        }
    }
    void output()

    {
        System.out.println("Array :");
        for(int element:a)
        {
            System.out.print(element+"\t");            
        }
        System.out.println(" ");
    }
}
class twoD
{
    int a[][];
    int r,c;
    Scanner s=new Scanner(System.in);
    twoD()
    {
        System.out.println("Enter row and column of array ");
        
        r=s.nextInt();
        c=s.nextInt();
        a=new int[r][c];
        
    }
    void input()

    {
        System.out.println("Enter "+r*c+" number :");
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                a[i][j]=s.nextInt();
            }
        }
    }
    void output()

    {
        System.out.println("Array :");
        for(int element[]:a)
        {
            for(int element1:element)
            {
                System.out.print(element1+"\t");
            }
            System.out.println(" ");            
        }
        
    }
}

class threeD
{
    int a[][][];
    int r,c,n;
    Scanner s=new Scanner(System.in);
    threeD()
    {
        System.out.println("Enter num of matrix ");
        n=s.nextInt();
        System.out.println("Enter row and column of array ");
        
        r=s.nextInt();
        c=s.nextInt();
        a=new int[n][r][c];
        
    }
    void input()

    {
        System.out.println("Enter "+n*r*c+" number :");
        for(int k=0;k<n;k++)
        {
            for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                a[k][i][j]=s.nextInt();
            }
        }
        }
    }
    void output()

    {
        System.out.println("Array :");
        for(int element[][]:a)
        {
            for(int element1[]:element)
            {
                for(int element2:element1)
                {
                    System.out.print(element2+"\t");
                }
                System.out.println(" "); 
            }
            System.out.println(" "); 
                       
        }
        
    }
}

public class a09 
{
    public static void main(String[] args) 
    {
        oneD o=new oneD();
        o.input();
        o.output();

        twoD t=new twoD();
        t.input();
        t.output();

        threeD tr=new threeD();
        tr.input();
        tr.output();
    }
}
