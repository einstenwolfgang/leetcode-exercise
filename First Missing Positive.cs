public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        if (nums.Length < 1) return 1;
        Array.Sort(nums);
        int i = 0;
        while (i < nums.Length && nums[i] < 1)
        {
            i++;
        }
        int count = 1;
        while (i < nums.Length && count == nums[i])
        {
            count++;
            while (i + 1 < nums.Length && nums[i] == nums[i + 1])
            {
                i++;
            }
            i++;
        }
        if (i == nums.Length) i--;
        return nums[i] > count ? count : nums[i] + 1;
    }
}