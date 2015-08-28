public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int remain = target - nums[i];
            if (dic.ContainsKey(remain)) return new int[] { dic[remain], i + 1 };
            else
            {
                dic.Add(nums[i], i + 1);
            }
        }
        return null;
    }
}