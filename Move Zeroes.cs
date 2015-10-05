public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] == 0 && nums[j] != 0)
                {
                    nums[i] = nums[j];
                    nums[j] = 0;
                }
            }
        }
    }
}