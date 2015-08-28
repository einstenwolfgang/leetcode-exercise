public class Solution
{
    public int MyAtoi(string str)
    {
        int max = int.MaxValue;
        int min = int.MinValue;
        long result = 0;
        str = str.Trim();
        int len = str.Length;
        if (len < 1)
            return 0;
        int start = 0;
        bool neg = false;

        if (str[start] == '-' || str[start] == '+')
        {
            if (str[start] == '-')
                neg = true;
            start++;
        }

        for (int i = start; i < len; i++)
        {
            char ch = str[i];

            if (ch < '0' || ch > '9')
                break;
            result = 10 * result + (ch - '0');
            if (!neg && result > max)
                return max;
            if (neg && -result < min)
                return min;

        }
        if (neg)
            result = -result;

        return (int)result;
    }
}