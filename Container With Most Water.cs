public class Solution
{
    public int MaxArea(int[] height)
    {
        int i = 0;
        int j = height.Length - 1;

        int ret = 0;
        while (i < j)
        {
            int area = (j - i) * Math.Min(height[i], height[j]);
            ret = Math.Max(ret, area);

            if (height[i] <= height[j])
                i++;
            else
                j--;
        }

        return ret;
    }
}