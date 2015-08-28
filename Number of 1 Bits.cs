public class Solution
{
    public int HammingWeight(uint n)
    {
        int re = 0;

        while (0 != n)
        {
            n = n & (n - 1);
            ++re;
        }

        return re;
    }
}