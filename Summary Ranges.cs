public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums == null) return null;
        List<string> result = new
         List<string>();
        if (nums.Length < 1) return result;
        int start = 0;
        int next = 0;
        while (next < nums.Length)
        {
            if (next + 1 < nums.Length && nums[next + 1] == nums[next] + 1)
            {
                next++;
            }
            else
            {
                if (start == next) result.Add(nums[next].ToString());
                else
                {
                    string str = nums[start].ToString() + "->" + nums[next].ToString();
                    result.Add(str);
                }
                ++next;
                start = next;
            }
        }
        return result;
    }
}