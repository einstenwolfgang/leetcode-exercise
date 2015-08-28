public class Solution
{
    string transmit(StringBuilder s)
    {
        //s = s.ToLowerInvariant();
        int i, j;
        //string res;
        for (i = j = 0; i < s.Length; i++)
        {
            if (s[i] <= '9' && s[i] >= '0')
            {
                s[j++] = s[i];
            }
            else if (s[i] <= 'z' && s[i] >= 'a')
            {
                s[j++] = s[i];
            }
            else if (s[i] <= 'Z' && s[i] >= 'A')
            {
                s[j++] = Char.ToLowerInvariant(s[i]);
            }
        }
        string str = s.ToString();
        str = str.Substring(0, j);

        return str;
    }

    public bool IsPalindrome(string s)
    {
        StringBuilder str = new StringBuilder(s);
        s = transmit(str);
        int i, j;
        for (i = 0, j = s.Length - 1; i <= j; i++, j--)
        {
            if (s[i] != s[j]) return false;

        }
        return true;
    }
}