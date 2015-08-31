public class Solution
{
    public int SingleNumber(int[] nums)
    {
        if (nums.Length < 1) return -1;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], 1);
            }
            else dic[nums[i]] = 2;
        }
        foreach (int i in dic.Keys)
        {
            if (dic[i] == 1) return i;
        }
        return -1;
    }
}