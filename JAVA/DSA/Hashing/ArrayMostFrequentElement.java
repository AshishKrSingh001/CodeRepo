
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;

public class ArrayMostFrequentElement
{
    public static int mostFrequentElementInArray(int[] A)
    {
        HashMap<Integer, Integer>map = new HashMap<>();
        int maxFreq = 0;
        int ans = -1;
        for(int i=0;i<A.length;i++)
        {
            map.put(A[i], map.getOrDefault(A[i], 0)+1);
            if(maxFreq < map.get(A[i]))
            {
                ans = A[i];
            }
        }
        return ans;
    }
    public static ArrayList<ArrayList<Integer>> getPairs(int[] A)
    {
        int n = A.length;
        ArrayList<ArrayList<Integer>>res = new ArrayList<ArrayList<Integer>>();
        HashMap<Integer, Integer>map = new HashMap<>();
        for(int i=0;i<n;i++)
        {
            map.put(A[i], map.getOrDefault(A[i], 0)+1);
        }
        for(int i=0;i<n;i++)
        {
            int k = A[i];
            int val=0;
            if(map.containsKey(k))
                val = map.get(k);
            else
                continue;
            if(val == 1)
            {
                map.remove(k);
            }
            else
            {
                map.put(k, map.get(k)-1);
            }
            ArrayList<Integer> list = new ArrayList<>();
            for(int key : map.keySet())
            {
                if(k+key == 0)
                {
                    if(k<key)
                    {
                        list.add(k);
                        list.add(key);
                    }
                    else
                    {
                        list.add(key);
                        list.add(k);
                    }
                    val = map.get(key);
                    if(val == 1)
                    {
                        map.remove(k);
                    }
                    else
                    {
                        map.put(k, val-1);
                    }
                    break;
                }
            }
            if(!list.isEmpty())
            {
                boolean flag = false;
                for(ArrayList<Integer>list1 : res)
                {
                    if(list1.equals(list))
                    {
                        flag = true;
                    }
                }
                if(!flag)
                {
                    res.add(list);
                }
            }
        }
        return res;
    }
    public static boolean kSumSubArray(int[]A, int K)
    {
        int N = A.length;
        for(int i=0;i<N;i++)
        {
            int max = 0;
            for(int j=i;j<N;j++)
            {
                if(max == K)
                {
                    return true;
                }
                max += A[j];
            }
        }
        return false;
    }
    public static boolean kSumSubArray2(int[]A, int K)
    {
        int N = A.length;
        int sum = 0;
        HashSet<Integer>set = new HashSet<>();
        set.add(0);
        for(int i=0;i<N;i++)
        {
            sum += A[i];
            int val = sum - K;
            if(set.contains(val))
            {
                return true;
            }
            set.add(sum);
        }
        return false;
    }
    public static ArrayList<Integer>kSumSubArrayPattern2(int[]A, int K)
    {
        ArrayList<Integer>list = new ArrayList<>();
        list.add(-1);

        HashMap<Integer, Integer>map = new HashMap<>();
        map.put(0, -1);

        int sum = 0;
        for(int i=0;i<A.length;i++)
        {
            sum += A[i];
            int val = sum - K;
            // System.out.println(val);
            if(map.containsKey(val))
            {
                list.set(0, map.get(val)+2);
                list.add(i+1);
            }
            map.put(sum, i);
        }
        return list;
    }
    public static int kSumSubArrayPattern3(int[]A, int K)
    {
        int maxLen = 0;
        HashMap<Integer, Integer>map = new HashMap<>();
        map.put(0, -1);

        int sum = 0;
        for(int i=0;i<A.length;i++)
        {
            sum += A[i];
            int val = sum - K;
            // System.out.println(val);
            if(map.containsKey(val))
            {
                int len = i-map.get(val);
                maxLen =  Math.max(maxLen, len);
            }
            if(!map.containsKey(sum))
            {
                map.put(sum, i);
            }
        }
        return maxLen;
    }
    public static int kSumSubArrayPattern4(int[]A, int K)
    {
        int noOfSubArray = 0;
        int N = A.length;
        int sum = 0;
        HashSet<Integer>set = new HashSet<>();
        set.add(0);
        for(int i=0;i<N;i++)
        {
            sum += A[i];
            int val = sum - K;
            if(set.contains(val))
            {
                noOfSubArray += 1;
            }
            set.add(sum);
        }
        return noOfSubArray;
    }
    public static void main(String[] args) 
    {
        int A[] = {1, -1, 0};
        System.out.println(kSumSubArrayPattern4(A, 2));    
    }
}