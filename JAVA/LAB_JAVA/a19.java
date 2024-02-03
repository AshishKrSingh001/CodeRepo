// .WAP in java to input five matrix after that print all matrices.
package LAB_JAVA;
import java.util.Scanner;
class three_d
{
    int a[][][];
    int r,c,n;
    Scanner s=new Scanner(System.in);
    three_d()
    {
        System.out.println("Enter no of mattrix: ");
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
public class a19 
{
    public static void main(String[] args) 
    {
        three_d t = new three_d();
        t.input();
        t.output();
    }
}
