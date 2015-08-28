public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> res = new List<IList<int>>();
        if (nums.Length < 3) return res;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int count = nums[i];
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k)
            {
                if (nums[j] + nums[k] == -count)
                {
                    res.Add(new List<int>() { nums[i], nums[j], nums[k] });
                    while (j < k && nums[j] == nums[j + 1]) j++;
                    while (j < k && nums[k] == nums[k - 1]) k--;
                    k--;
                    j++;
                }
                else if (nums[j] + nums[k] > -count)
                    k--;
                else j++;
            }

        }
        return res;
    }
}