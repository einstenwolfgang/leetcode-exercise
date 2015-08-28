public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        List<int> res = new List<int>();
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], 1);
            else
            {
                dic[nums[i]]++;
            }
        }
        foreach (int i in dic.Keys)
        {
            if (dic[i] > n / 3)
                res.Add(i);
        }
        return res;
    }
}