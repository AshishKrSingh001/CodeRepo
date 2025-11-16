// WAP in java to input any matrix after that print transpose of that matrix
package LAB_JAVA;
import java.util.Scanner;
class Matrix1
{
    int a[][];
    int r,c;
    Scanner s=new Scanner(System.in);
    Matrix1()
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
        System.out.println("Matrix :");
        for(int element[]:a)
        {
            for(int element1:element)
            {
                System.out.print(element1+"\t");
            }
            System.out.println(" ");            
        }
        
    }
    void transpose()
    {
        int [][]arr = new int[r][c];
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                arr[i][j]=a[j][i];
            }
        }
        System.out.println("Transpose Matrix :");
        for(int element[]:arr)
        {
            for(int element1:element)
            {
                System.out.print(element1+"\t");
            }
            System.out.println(" ");            
        }
    }
    public static void main(String[] args) 
    {
        Matrix1 mat = new Matrix1();
        mat.input();
        mat.output();
        mat.transpose();    
    }
}
