import java.util.Scanner;
public class a55_array_searching_binary
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

        //Sorting
        for(i=0;i<size-1;i++)
        {
            for(int j=i+1;j<size;j++)
            {
                if(arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        //Input Searching element
        System.out.println("Enter searching element:");
        int src = sc.nextInt();

        //searching
        int min = 0,max = size-1,mid;
        while(min < max)
        {
            mid = (min + max)/2;
            if(arr[mid]<src)
            {
                min = mid;
            }
            if(arr[mid]>src)
            {
                max = mid;
            }
            if(arr[mid]==src)
            {
                System.out.println("Found");
                break;
            }
        }
        if(min >= max)
        {
            System.out.println("Not found");
        }


    }
}
