public class Solution
{
    public int TitleToNumber(string s)
    {
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            res = res * 26 + (s[i] - 'A' + 1);
        }
        return res;
    }
}