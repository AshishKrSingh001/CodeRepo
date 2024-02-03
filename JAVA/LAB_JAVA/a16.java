// WAP in java to input any square matrix after that find sum of top,bottom,left and right line elements of matrix
package LAB_JAVA;
import java.util.Scanner;
class Matrix2
{
    int a[][];
    int r,c;
    Scanner s=new Scanner(System.in);
    Matrix2()
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
    void Addition()
    {
        int top=0,bottom=0,left=0,right=0;
        for(int i=0;i<r;i++)
        {
            left = left+a[i][0];
                right = right+a[i][c-1];
        }
        for(int j=0;j<c;j++)
            {
                top = top+a[0][j];
                bottom = bottom+a[r-1][j];
            }
        System.out.println("Addition of top: "+top);
        System.out.println("Addition of bottom: "+bottom);
        System.out.println("Addition of left: "+left);
        System.out.println("Addition of right: "+right);
    }
    public static void main(String[] args) 
    {
        Matrix2 mat = new Matrix2();
        mat.input();
        mat.output();
        mat.Addition();    
    }
}

