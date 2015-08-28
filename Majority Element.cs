public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int res = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (res == nums[i])
                count++;
            else
            {
                count--;
                if (count == 0)
                {
                    res = nums[i];
                    count = 1;
                }
            }
        }
        return res;
    }
}