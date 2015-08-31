public class Solution
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Length < 1) return 0;
        if (nums.Length == 1) return nums[0];
        int curmin = nums[0];
        int curmax = nums[0];
        int ans = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            int temp = curmin * nums[i];
            curmin = Math.Min(nums[i], Math.Min(temp, curmax * nums[i]));
            curmax = Math.Max(nums[i], Math.Max(temp, curmax * nums[i]));
            ans = Math.Max(ans, curmax);
        }
        return ans;
    }
}