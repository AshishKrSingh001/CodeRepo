public class BinarySearch 
{
    public static void main(String[] args) 
    {
        int A[] = {2, 2, 7, 7, 7, 9, 25, 56};
        printArray(A);
        // System.out.println(findMinimumAbsDiff(A, 99));
        // System.out.println(binarySearchInInfiniteArray(A, 1));
        // System.out.println(binarySearchInAccoToOccurance(A, 7, false));

        int []range = findingRangeInInfiniteArray(A, 7);
        System.out.println(binarySearchInInfiniteArrayFirstOccurance(A, 7, range[0], range[1]));
    }
    public static int[] findingRangeInInfiniteArray(int[]A, int target)
    {
        int[]range = new int[2];
        int start = 0, end = 1;
        while(A[end]<target)
        {
            start = end;
            end = end *2;
            if(end>=A.length)
                end = A.length-1;
        }
        range[0] = start;
        range[1] = end;
        return range;
    }
    public static int binarySearchInInfiniteArrayFirstOccurance(int A[], int target, int start, int end)
    {
        if(A.length==0)
        {
            return 0;
        }
        int res=-1;
        while(start<=end)
        {
            int mid = (start+end)/2;
            if(A[mid] == target)
            {
                res = mid;
                end = mid - 1;
            }
            else if(A[mid] < target)
            {
                start = mid + 1;
            }
            else if(A[mid] > target)
            {
                end = mid - 1;
            }
        }
        return res;
    }
    public static int binarySearchInInfiniteArray(int A[], int target)
    {
        if(A.length==0)
        {
            return 0;
        }
        int start = 0, end = 1;
        while(start<=end)
        {
            int mid = (start+end)/2;
            if(A[end]<target)
            {
                start = end;
                end = end*2;
                if(end<=A.length)
                    end = A.length-1;
            }
            else if(A[mid] == target)
            {
                return mid;
            }
            else if(A[mid] < target)
            {
                start = mid + 1;
            }
            else if(A[mid] > target)
            {
                end = mid - 1;
            }
        }
        return -1;
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
    public static int findMinimumAbsDiff(int []A, int target)
    {
        if(A.length==0)
        {
            return 0;
        }
        int start = 0, end = A.length-1;
        while(start<=end)
        {
            int mid = (start+end)/2;
            if(A[mid] == target)
            {
                return 0;
            }
            else if(A[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        if(end == -1 || start==A.length)
        {
            return (end == -1)?Math.abs(A[start]-target):Math.abs(A[end]-target);
        }
        return (Math.abs(A[start]-target)>Math.abs(A[end]-target)?Math.abs(A[end]-target):Math.abs(A[start]-target));
    }
    public static int binarySearchInFirstOccurance(int A[], int target)
    {
        if(A.length==0)
        {
            return 0;
        }
        int start = 0, end = A.length-1, res=-1;
        while(start<=end)
        {
            int mid = (start+end)/2;
            if(A[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                if(A[mid] == target)
                {
                    res = mid;
                }
                end = mid - 1;
            }
        }
        return res;
    }
    public static int binarySearchInLastOccurance(int A[], int target)
    {
        if(A.length==0)
        {
            return 0;
        }
        int start = 0, end = A.length-1, res=-1;
        while(start<=end)
        {
            int mid = (start+end)/2;
            if(A[mid] <= target)
            {
                if(A[mid] == target)
                {
                    res = mid;
                }
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return res;
    }
    public static int binarySearchInAccoToOccurance(int A[], int target, boolean isFirst)
    {
        if(A.length==0)
        {
            return 0;
        }
        int start = 0, end = A.length-1, res=-1;
        while(start<=end)
        {
            int mid = (start+end)/2;
            if(A[mid] == target)
            {
                res = mid;
                if(isFirst)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            else if(A[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return res;
    }
}
