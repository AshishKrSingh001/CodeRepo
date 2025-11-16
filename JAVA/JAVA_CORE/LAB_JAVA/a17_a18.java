// WAP in java to input two matix after that find addition and subtraction
// WAP in java to input two matix after that find multiplication.

package LAB_JAVA;
import java.util.Scanner;
class Matrix
{
    int a[][];
    int r,c;
    Scanner s = new Scanner(System.in);
    Matrix(int row,int col)
    {
        r=row;
        c=col;
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
        System.out.println("\nMatrix :");
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
class Matrix3
{
    public static void main(String[] args) 
    {
        Scanner s = new Scanner(System.in);
        int r,c;
        System.out.println("\nEnter row and column of array ");
        r=s.nextInt();
        c=s.nextInt();
        Matrix m = new Matrix(r,c);
        m.input();
        m.output();

        Matrix m1 = new Matrix(r,c);
        m1.input();
        m1.output();

        System.out.println("\nAddition: ");
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                System.out.print((m1.a[i][j]+m.a[i][j])+"\t");
            }
            System.out.println(" "); 
        }

        System.out.println("\nSubtraction: ");
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                System.out.print((m1.a[i][j]-m.a[i][j])+"\t");
            }
            System.out.println(" "); 
        }

        System.out.println("\nMuliplication: ");
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                System.out.print((m1.a[i][j]*m.a[i][j])+"\t");
            }
            System.out.println(" "); 
        }
    }
}

