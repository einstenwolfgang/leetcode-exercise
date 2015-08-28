public class Solution
{
    public uint reverseBits(uint n)
    {
        uint key = 0;
        uint val = 0;
        if (n == key) return val;
        if (n == val) return key;
        uint ret = 0;
        int index = 31;
        key = n;
        while (n > 0)
        {
            ret |= (n & 0x1) << index;
            n >>= 1;
            index--;
        }
        val = ret;
        return val;
    }
}