public class Solution
{
    public int NumSquares(int n)
    {
        int[] min = new int[n + 1];
        min[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            int tmp = int.MaxValue;
            for (int j = 1; j * j <= i; j++)
            {
                tmp = Math.Min(tmp, min[i - j * j] + 1);
            }
            min[i] = tmp;
        }
        return min[n];
    }
}