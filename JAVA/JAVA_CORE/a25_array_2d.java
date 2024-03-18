import java.util.Scanner;
public class a58_array_2d
{
    public static void main(String[] args)
    {
        System.out.println("Enter row and column:");
        Scanner sc = new Scanner(System.in);
        int r = sc.nextInt();//Row
        int c = sc.nextInt();//Column
        int[][] arr = new int[r][c];
        int i,j;


        //Array input
        System.out.printf("Enter %d array element:\n",r*c);
        for(i=0;i<r;i++)
        {
            for(j=0;j<c;j++)
            {
                arr[i][j] = sc.nextInt();
            }
        }

        //Array display
        System.out.println("array:");
        for(i=0;i<r;i++)
        {
            for(j=0;j<c;j++)
            {
                System.out.printf("%d\t",arr[i][j]);
            }
            System.out.println("\n");
        }






    }
}
