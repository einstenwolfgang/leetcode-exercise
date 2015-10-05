public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int[] pair = new int[s.Length];
        int result = 0;
        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (s[i] == '(')
            {
                if (s[i + 1] == ')') pair[i] = 2;
                else if (pair[i + 1] != 0 && i + pair[i + 1] + 1 < s.Length && s[i + pair[i + 1] + 1] == ')')
                    pair[i] = pair[i + 1] + 2;
                if (pair[i] != 0 && i + pair[i] < s.Length && pair[i + pair[i]] != 0)
                    pair[i] += pair[i + pair[i]];
            }
            result = Math.Max(result, pair[i]);
        }
        return result;
    }
}