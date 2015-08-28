public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows < 1) return new List<IList<int>>();
        List<IList<int>> ivec = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            List<int> vec = new List<int>();
            for (int j = 0; j < i + 1; j++)
            {
                if (j == 0 || j == i) vec.Add(1);
                else
                {
                    vec.Add(ivec[i - 1][j - 1] + ivec[i - 1][j]);
                }
            }
            ivec.Add(vec);
        }
        return ivec;
    }
}