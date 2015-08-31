public class Solution
{
    public int Calculate(string s)
    {
        if (s == null || s.Length == 0) return 0;
        Stack<int> stack = new Stack<int>();
        int res = 0;
        int sign = 1;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (Char.IsDigit(c))
            {
                int cur = c - '0';
                while (i + 1 < s.Length && Char.IsDigit(s[i + 1]))
                {
                    cur = 10 * cur + s[++i] - '0';
                }
                res += sign * cur;
            }
            else if (c == '-')
            {
                sign = -1;
            }
            else if (c == '+')
            {
                sign = 1;
            }
            else if (c == '(')
            {
                stack.Push(res);
                res = 0;
                stack.Push(sign);
                sign = 1;
            }
            else if (c == ')')
            {
                res = stack.Pop() * res + stack.Pop();
                sign = 1;
            }
        }
        return res;
    }
}