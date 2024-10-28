public class Test 
{
    public static void printArray(int A[])
    {
        for(int i=0;i<A.length;i++)
        {
            System.out.print(A[i]);
            if(i!=A.length-1)
            {
                System.out.print(", ");
            }
        }
        System.out.println("");
    }
    public static void main(String[] args) 
    {
        int A[] = {85, 96, 101, 105, 107,  2, 3, 4, 5, 64};
        printArray(A);
        System.out.println(searchElementInRotatedArray(A, 55));
        // int min = minElementInRotatedArray(A);
        // if(min!=-1)
        //     System.out.println(A[min]);
        // else
        //     System.out.println("Invalid");

        // int max = maxElement(A);
        // if(max!=-1)
        //     System.out.println(A[max]);
        // else
        //     System.out.println("Invalid");
    }
    public static int searchElementInRotatedArray(int A[], int target)
    {
        int start = 0;
        int end = A.length - 1;
        while(start<=end)
        {
            int mid = (start + end) / 2;
            if(A[mid] == target)
            {
                return mid;
            }
            else if(A[start] <= A[mid])
            {
                if(A[start] <= target && A[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            else
            {
                if(A[mid] > target && A[end] <= target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
        }
        return -1;
    }
    public static int minElementInRotatedArray(int A[])
    {
        if(A.length == 0)
            return  -1;
        else if(A.length == 1)
            return 0;
        int start = 0, end = A.length-1;
        while(start<end)
        {
            int mid = (start+end)/2;
            if(A[mid] == A[start] && A[mid] == A[end])
            {
                start++;end--;
            }
            if(mid>0 && A[mid] < A[mid-1])
            {
                return mid;
            }
            else if(A[mid] < A[start])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return start;
        
    }
    public static int maxElement(int A[])
    {
        int start = 0;
        int end = A.length - 1;
        while(start<end)
        {
            int mid = (start + end)/2;
            if(mid<A.length-1 && A[mid]>A[mid+1])
            {
                return mid;
            }
            else if(A[mid] < A[start])
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        return end;
    }
}
