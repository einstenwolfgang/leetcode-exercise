public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);
        IList<int> each = new List<int>();
        helper(res, each, 0, nums);
        return res;
    }

    void helper(IList<IList<int>> res, IList<int> each, int pos, int[] nums)
    {
        if (pos <= nums.Length)
        {
            res.Add(each);
        }
        int i = pos;
        while (i < nums.Length)
        {
            each.Add(nums[i]);
            helper(res, new List<int>(each), i + 1, nums);
            each.RemoveAt(each.Count - 1);
            i++;
            while (i < nums.Length && nums[i] == nums[i - 1]) i++;
        }
        return;
    }
}