import java.util.Scanner;
public class a51_array
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter size of array:");
        int n = sc.nextInt();
        int [] marks = new int [n];
        System.out.printf("Enter %d numbers:\n",n);
        for(int i=0;i<n;i++)
        {
            marks[i] = sc.nextInt();
        }
        marks[3]=3;
        System.out.println("Array is:");
        for(int i=0;i<n;i++)
        {
            System.out.printf("%d\t",marks[i]);
        }
        System.out.println("\nLength of array = "+marks.length);
        marks[3]=3;
        System.out.println(marks[3]);

    }
}
