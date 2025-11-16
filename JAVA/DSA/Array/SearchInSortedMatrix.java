public class SearchInSortedMatrix 
{
    public static void main(String[] args) {
        int A[][] = {
            {1, 3, 5, 7},
            {10, 11, 16, 20},
            {23, 30, 34, 60}
        };
        System.out.println(search(A, -100));
    }
    public static boolean search(int A[][], int target)
    {
        int start = 0;
        int end = A.length-1;
        int row = 0;
        while(start <= end)
        {
            int mid = (start+end)/2;
            // System.out.println(mid);
            if(A[mid][A[0].length-1] >= target)
            {
                if(mid>0 && A[mid-1][A[0].length-1] < target)
                {
                    row = mid;
                    break;
                }
                else if(mid == 0)
                {
                    row = 0;
                    break;
                }
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        // System.out.println(row);
        start = 0;
        end = A[row].length-1;
        while(start <= end)
        {
            int mid = (start+end)/2;
            if(A[row][mid] == target)
            {
                return true;
            }
            else if(A[row][mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return false;
    }
}
