import java.util.Scanner;
public class a53_array_sorting_bubble
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int n,i,j;
        System.out.println("Enter size of array:");
        n = sc.nextInt();
        int[] arr;
        arr = new int[n];
        //Inputting array element
        System.out.printf("Enter %d number:\n",n);
        for(i=0;i<n;i++)
        {
            arr[i] = sc.nextInt();
        }

        //Displaying before sorting
        System.out.println("Array before sorting:");
        for(i=0;i<n;i++)
        {
            System.out.printf("%d\t",arr[i]);
        }

        //Sorting
        for(i=0;i<n;i++)
        {
            for(j=i;j<n;j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }

        //Displaying after sorting
        System.out.println("\nArray after sorting:");
        for(i=0;i<n;i++)
        {
            System.out.printf("%d\t",arr[i]);
        }
    }
}
