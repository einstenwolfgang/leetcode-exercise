public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length < 3) return 0;
        Array.Sort(nums);
        int res = nums[0] + nums[1] + nums[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k)
            {
                int m = nums[i] + nums[j] + nums[k];
                if (Math.Abs(m - target) < Math.Abs(res - target)) res = m;
                if (m == target) return target;
                if (m > target) k--;
                else j++;
            }
        }
        return res;
    }
}