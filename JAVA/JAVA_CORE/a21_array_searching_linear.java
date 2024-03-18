import java.util.Scanner;
public class a54_array_searching_linear
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter size of array:");
        int size = sc.nextInt();
        int[] arr = new int[size];
        int i;
        //Array input
        System.out.printf("Enter %d numbers:\n",size);
        for(i=0;i<size;i++)
        {
            arr[i] = sc.nextInt();
        }

        //Input Searching element
        System.out.println("Enter searching element:");
        int src = sc.nextInt();

        //searching
        for(i=0;i<size;i++)
        {
            if(arr[i] == src)
            {
                System.out.println("Found");
                break;
            }
        }
        if(i==size)
        {
            System.out.println("Not found");
        }


    }
}
