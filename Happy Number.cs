public class Solution
{
    public bool IsHappy(int n)
    {
        if (n < 1) return false;
        if (n == 1) return true;
        HashSet<int> set = new HashSet<int>();
        set.Add(n);
        while (true)
        {
            int num = 0;
            while (n != 0)
            {
                int digit = n % 10;
                n /= 10;
                num += digit * digit;
            }
            if (num == 1) return true;
            else
            {
                if (set.Contains(num)) return false;
                set.Add(num);
            }
            n = num;
        }
    }
}