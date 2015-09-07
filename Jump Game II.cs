public class Solution
{
    public int Jump(int[] nums)
    {
        int res = 0;
        int curreach = 0;
        int curmax = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (curreach < i)
            {
                res++;
                curreach = curmax;
            }
            curmax = Math.Max(curmax, nums[i] + i);
        }
        return res;
    }
}