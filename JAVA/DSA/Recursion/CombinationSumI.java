
import java.util.List;
import java.util.ArrayList;

public class CombinationSumI 
{
    public List<List<Integer>> combinationSum(int[] candidates, int target) 
    {
        List<List<Integer>> res = new ArrayList<List<Integer>>();
        List<Integer>subList = new ArrayList<Integer>();
        recur(candidates, target, 0, subList, res);
        return res;
    }
    public void recur(int[]candidates, int target, int index, List<Integer>subList, List<List<Integer>> res)
    {
        // base case
        if(index == candidates.length)
        {
            res.add(new ArrayList<Integer>(subList));
            return;
        }
        // pick
        subList.add(candidates[index]);
        recur(candidates, target, 0, subList, res);
        subList.remove(subList.size()-1);

        // No pick
        recur(candidates, target, 0, subList, res);
    }
}
