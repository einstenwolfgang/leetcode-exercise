public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x == 0) return true;
        int b = 1;
        while (x / b >= 10) b *= 10;
        while (x != 0)
        {
            int left = x / b;
            int right = x % 10;
            if (left != right) return false;

            x -= left * b;
            b /= 100;
            x /= 10;
        }
        return true;
    }
}