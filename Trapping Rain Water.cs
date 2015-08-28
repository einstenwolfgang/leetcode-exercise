public class Solution
{
    public int Trap(int[] height)
    {
        int n = height.Length;
        if (n <= 2) return 0;
        int maxid = 0;
        for (int i = 0; i < n; i++)
        {
            if (height[maxid] < height[i])
                maxid = i;
        }
        int curheight = height[0];
        int water = 0;
        for (int i = 1; i < maxid; i++)
        {
            if (curheight < height[i]) curheight = height[i];
            else water += curheight - height[i];
        }
        curheight = height[n - 1];
        for (int i = n - 2; i > maxid; i--)
        {
            if (curheight < height[i]) curheight = height[i];
            else water += curheight - height[i];
        }
        return water;
    }
}