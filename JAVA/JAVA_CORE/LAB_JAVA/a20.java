// WAP in java to input five matrix after that find sum of elements for each matrix.
package LAB_JAVA;
import java.util.Scanner;
class three_D
{
    int a[][][];
    int r,c,n;
    Scanner s=new Scanner(System.in);
    three_D()
    {
        n=5;
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
    void Addition()
    {
        System.out.println("Addition: ");
        for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    System.out.print((a[0][i][j]+a[1][i][j]+a[2][i][j]+a[3][i][j]+a[4][i][j])+"\t");
                }
                System.out.println(" "); 
            }
            System.out.println(" "); 
    }
}
public class a20 
{
    public static void main(String[] args) 
    {
        three_D t = new three_D();
        t.input();
        t.output();
        t.Addition();
    }
}
