public class Solution
{
    public IList<int> SpiralOrder(int[,] matrix)
    {
        IList<int> result = new List<int>();
        if (matrix.GetLength(0) < 1) return result;
        int beginX = 0, endX = matrix.GetLength(1) - 1;
        int beginY = 0, endY = matrix.GetLength(0) - 1;
        while (true)
        {
            for (int i = beginX; i <= endX; ++i)
                result.Add(matrix[beginY, i]);
            if (++beginY > endY) break;
            for (int i = beginY; i <= endY; ++i)
                result.Add(matrix[i, endX]);
            if (beginX > --endX) break;
            for (int i = endX; i >= beginX; --i)
                result.Add(matrix[endY, i]);
            if (beginY > --endY) break;
            for (int i = endY; i >= beginY; --i)
                result.Add(matrix[i, beginX]);
            if (++beginX > endX) break;
        }
        return result;
    }
}