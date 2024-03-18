import java.util.Scanner;
public class a52_array_sorting_selection
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
        for(i=0;i<n-1;i++)
        {
            for(j=i+1;j<n;j++)
            {
                if(arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
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
