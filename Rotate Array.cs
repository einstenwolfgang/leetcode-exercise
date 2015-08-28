public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        if (k == 0) return;
        k %= len;
        Reverse(nums, 0, len - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, len - 1);
    }

    void Reverse(int[] nums, int k, int n)
    {
        while (k <= n)
        {
            int temp = nums[k];
            nums[k] = nums[n];
            nums[n] = temp;
            k++;
            n--;
        }
    }
}