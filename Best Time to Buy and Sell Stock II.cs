public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int ans = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i + 1] > prices[i])
                ans += prices[i + 1] - prices[i];
        }
        return ans;
    }
}