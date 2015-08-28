public class Solution
{
    public int[] SingleNumber(int[] nums)
    {
        if (nums.Length < 2) return null;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int[] res = new int[2];
        int count = 0;
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
            if (dic[i] == 1 && count == 0)
            {
                res[0] = i;
                count++;
            }
            if (dic[i] == 1 && count == 1) res[1] = i;
        }
        return res;
    }
}