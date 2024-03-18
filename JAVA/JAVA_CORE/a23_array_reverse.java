public class a56_array_reverse
{
    public static void main(String[] args)
    {
        int[] arr = {1,2,3,4,5,6,7,8};
        int [] a = new int[arr.length];
        for(int i=arr.length-1,j=0;i>=0;i--,j++)
        {
           a[j]=arr[i];
        }

        System.out.println("array");
        for(int i=0;i<arr.length;i++)
        {
            System.out.printf("%d\t",arr[i]);
        }

        System.out.println("\narray_Reverse");
        for(int i=0;i<arr.length;i++)
        {
            System.out.printf("%d\t",a[i]);
        }
    }
}
