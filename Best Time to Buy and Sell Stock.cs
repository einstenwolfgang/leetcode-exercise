public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length < 1) return 0;
        int low = prices[0];
        int res = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < low) low = prices[i];
            else if (prices[i] - low > res) res = prices[i] - low;
        }
        return res;
    }
}