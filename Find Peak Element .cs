public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        if (nums.Length == 1 || nums[0] > nums[1]) return 0;
        int n = nums.Length;
        if (nums[n - 2] < nums[n - 1]) return n - 1;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1] && nums[i] > nums[i - 1])
                return i;
        }
        return -1;
    }
}