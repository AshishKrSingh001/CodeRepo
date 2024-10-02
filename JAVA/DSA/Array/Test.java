public class Test 
{
    public static void main(String[] args) 
    {
        int A[] = {2, 4, 6, 9, 13, 55, 11, 9, 8, 5, 1};
        // int A[] = {55, 11, 9, 8, 5, 1};
        // int A[] = {2, 4, 6, 9, 13, 55};
        printArray(A);
        int index;
        // index = finMinElement(A);
        // index = finMaxElement(A);
        index = findElementInBitonicArray(A, 11);
        if(index!=-1)
            System.out.println(A[index]);
        else
            System.out.println("Invalid");
    }
    public static int findElementInBitonicArray(int[]A, int target)
    {
        int peak = finMaxElement(A);
        int index1 = binarySearch(A, target, 0, peak, true);
        int index2 = binarySearch(A, target, peak-1, A.length-1, false);
        if(index1 == -1 && index2 == -1)
        {
            return -1;
        }
        else
        {
            if(index1 == -1)
                return index2;
            else
                return index1;
        }

    }
    public static int binarySearch(int[]A, int target, int start, int end, boolean asc)
    {
        while(start<=end)
        {
            int mid = (start+end)/2;
            if(A[mid] == target)
            {
                return mid;
            }
            else if(A[mid] < target)
            {
                if(asc)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            else
            {
                if(asc)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
        }
        return -1;
    }
    public static int finMaxElement(int[]A)
    {
        int N = A.length;
        if(N==0)
        {
            return 0;
        }
        if(N==1)
        {
            return A[0];
        }
        int start = 0, end = N-1;
        while(start<=end)
        {
            int mid = (start+end)/2;
            int prev = (mid - 1 + N)%N;
            int next = (mid + 1)%N;
            // if(mid == A.length-1 || mid == 0)
            //     return A[mid];
            if(A[mid] > A[next] && A[mid] > A[prev])
            {
                return mid;
            }
            else if(A[mid] > A[next])
            {
                end = mid - 1;
            }
            else if(A[mid] < A[next])
            {
                start = mid + 1;
            }
        }
        return -1;
    } 
    public static int finMinElement(int[]A)
    {
        if(A.length==0)
        {
            return 0;
        }
        return(A[0]<A[A.length-1])?0:A.length-1;
    }
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
}
