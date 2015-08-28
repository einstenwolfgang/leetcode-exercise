public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int start = -1, end = -1;
        for (start = 0; start < nums.Length; start++)
        {
            if (nums[start] == target)
                break;
        }
        for (end = nums.Length - 1; end > 0; end--)
        {
            if (nums[end] == target)
                break;
        }
        int[] res = { -1, -1 };
        if (start <= end)
        {
            res[0] = start; res[1] = end;
        }
        return res;
    }
}