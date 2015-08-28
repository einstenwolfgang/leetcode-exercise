public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        //int res = nums.Length;
        int start = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (val != nums[i]) nums[start++] = nums[i];
        }
        return start;
    }
}