public class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        foreach (int i in matrix)
        {
            if (i == target)
            {
                return true;
            }
        }
        return false;
    }
}