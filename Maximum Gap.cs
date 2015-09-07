public class Solution
{
    public int MaximumGap(int[] nums)
    {
        Array.Sort(nums);
        if (nums.Length < 2) return 0;
        int result = nums[1] - nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result = Math.Max(result, nums[i] - nums[i - 1]);
        }
        return result;
    }
}