public class Solution
{
    public int Rob(int[] nums)
    {
        int best0 = 0;
        int best1 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = best0;
            best0 = Math.Max(best0, best1);
            best1 = temp + nums[i];
        }
        return Math.Max(best0, best1);
    }
}