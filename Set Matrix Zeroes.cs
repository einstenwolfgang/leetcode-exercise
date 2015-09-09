public class Solution
{
    public void SetZeroes(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int[] row = new int[m];
        int[] column = new int[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == 0)
                {
                    row[i] = 1;
                    column[j] = 1;
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (row[i] == 1 || column[j] == 1) matrix[i, j] = 0;
            }
        }
    }
}