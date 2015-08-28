public class Solution
{
    IList<IList<int>> res;
    IList<int> solu;

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        res = new List<IList<int>>();
        solu = new List<int>();
        Array.Sort(candidates);
        getComb(candidates, target, 0, 0);
        return res;
    }

    void getComb(int[] candidates, int target, int sum, int level)
    {
        if (sum > target) return;
        if (sum == target)
        {
            res.Add(new List<int>(solu));
            return;
        }
        for (int i = level; i < candidates.Length; i++)
        {
            solu.Add(candidates[i]);
            sum += candidates[i];
            getComb(candidates, target, sum, i + 1);
            solu.Remove(candidates[i]);
            sum -= candidates[i];
            while (i < candidates.Length - 1 && candidates[i] == candidates[i + 1])
            {
                i++;
            }
        }
    }
}