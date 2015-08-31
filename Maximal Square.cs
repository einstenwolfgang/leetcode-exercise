public class Solution
{
    public int MaximalSquare(char[,] matrix)
    {
        if (matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1) return 0;
        int m = matrix.GetLength(0); int n = matrix.GetLength(1);

        int[,] dp = new int[m, n];
        int res = 0;
        for (int i = 0; i < m; ++i)
        {
            if (matrix[i, 0] == '1')
            {
                dp[i, 0] = 1;
                res = 1;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            if (matrix[0, i] == '1')
            {
                dp[0, i] = 1; res = 1;
            }
        }

        for (int i = 1; i < m; ++i)
        {
            for (int j = 1; j < n; ++j)
            {
                if (matrix[i, j] == '1')
                    dp[i, j] = Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1])) + 1;
                res = Math.Max(res, dp[i, j]);
            }
        }
        return res * res;
    }
}