public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        if (nums == null) return null;
        int length = nums.Length;
        int[] temp = new int[length];
        int[] res = new int[length];
        temp[0] = 1;
        res[0] = 1;
        for (int i = 1; i < length; i++)
        {
            temp[i] = temp[i - 1] * nums[i - 1];
            res[i] = temp[i];
        }
        temp[length - 1] = 1;
        for (int i = length - 2; i >= 0; i--)
        {
            temp[i] = temp[i + 1] * nums[i + 1];
            res[i] *= temp[i];
        }

        return res;
    }
}