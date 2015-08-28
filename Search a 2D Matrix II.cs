public class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        if (matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1) return false;
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, 0] <= target && matrix[i, n - 1] >= target)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == target)
                        return true;
                }
            }
        }
        return false;
    }
}