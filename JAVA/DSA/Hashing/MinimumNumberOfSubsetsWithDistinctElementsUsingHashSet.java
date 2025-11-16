
import java.util.HashSet;

public class MinimumNumberOfSubsetsWithDistinctElementsUsingHashSet 
{
    public static int minNumberOfSubset(int A[])
    {
        int N = A.length;
        Boolean arr[] = new Boolean[N];
        for(int i=0;i<N;i++)
        {
            arr[i] = false;
        }
        int res = 0;
        for(int i=0;i<N;i++)
        {
            if(arr[i])
            {
                continue;
            }
            res++;
            HashSet<Integer>set = new HashSet<>();
            for(int j=i;j<N;j++)
            {
                if(!arr[j] && !set.contains(A[j]))
                {
                    arr[j] = true;
                    set.add(A[j]);
                }
            }
            System.out.println("Set: ->"+set);
            if(set.isEmpty())
            {
                break;
            }
        }
        return res;
    }
    public static void main(String[] args) 
    {
        int A[] = {2, 1, 4, 1, 6, 5, 5, 5};
        // 1-> {2, 1, 4, 6, 5} | 2-> {1, 5} | 3-> {5}
        System.out.println("Minimum Number Of Subset: "+minNumberOfSubset(A));
    }
}
