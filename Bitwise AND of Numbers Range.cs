public class Solution
{
    public int RangeBitwiseAnd(int m, int n)
    {
        int offset = 0;
        while (m != 0 && n != 0)
        {
            if (m == n)
            {
                return m << offset;
            }
            m >>= 1;
            n >>= 1;
            offset++;
        }

        return 0;
    }
}