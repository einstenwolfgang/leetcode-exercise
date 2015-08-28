public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        //if(rowIndex < 1)return new List<int>();
        List<List<int>> ivec = new List<List<int>>();
        for (int i = 0; i < rowIndex + 1; i++)
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
        return ivec[rowIndex];
    }
}