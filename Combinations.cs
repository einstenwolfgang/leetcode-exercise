public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> each = new List<int>();
        helper(res, each, k, n, 1);
        return res;
    }

    void helper(IList<IList<int>> res, IList<int> each, int k, int n, int index)
    {
        if (each.Count == k)
        {
            res.Add(each);
            return;
        }
        for (int i = index; i <= n; i++)
        {
            each.Add(i);
            helper(res, new List<int>(each), k, n, i + 1);
            each.RemoveAt(each.Count - 1);
        }
        return;
    }
}