public class Solution
{
    public int Candy(int[] ratings)
    {
        int[] res = new int[ratings.Length];
        for (int i = 0; i < ratings.Length; i++)
        {
            res[i] = 1;
        }
        int height = 1;
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1]) res[i] = ++height;
            else height = 1;
        }
        height = 1;
        for (int i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1]) res[i] = Math.Max(++height, res[i]);
            else height = 1;
        }
        return res.Sum();
    }
}