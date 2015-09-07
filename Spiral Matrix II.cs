public class Solution
{
    public int[,] GenerateMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        if (matrix.GetLength(0) < 1) return matrix;
        int beginX = 0, endX = matrix.GetLength(1) - 1;
        int beginY = 0, endY = matrix.GetLength(0) - 1;
        int count = 1;
        while (true)
        {
            for (int i = beginX; i <= endX; ++i)
            {
                matrix[beginY, i] = count;
                count++;
            }
            if (++beginY > endY) break;
            for (int i = beginY; i <= endY; ++i)
            {
                matrix[i, endX] = count;
                count++;
            }
            if (beginX > --endX) break;
            for (int i = endX; i >= beginX; --i)
            {
                matrix[endY, i] = count;
                count++;
            }
            if (beginY > --endY) break;
            for (int i = endY; i >= beginY; --i)
            {
                matrix[i, beginX] = count;
                count++;
            }
            if (++beginX > endX) break;
        }
        return matrix;
    }
}