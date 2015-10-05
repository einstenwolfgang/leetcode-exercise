public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            dp[i, 0] = i;
        }
        for (int i = 0; i <= n; i++)
        {
            dp[0, i] = i;
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (word1[i] == word2[j])
                {
                    dp[i + 1, j + 1] = dp[i, j];
                }
                else
                {
                    int a = dp[i, j + 1];
                    int b = dp[i + 1, j];
                    int c = dp[i, j];
                    dp[i + 1, j + 1] = 1 + Math.Min(a, Math.Min(b, c));
                }
            }
        }
        return dp[m, n];
    }
}