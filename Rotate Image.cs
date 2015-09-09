public class Solution
{
    public void Rotate(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int[,] temp = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                temp[i, j] = matrix[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, n - 1 - i] = temp[i, j];
            }
        }
        return;
    }
}