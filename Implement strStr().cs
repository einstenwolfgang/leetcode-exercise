public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int i, j;
        for (i = j = 0; i < haystack.Length && j < needle.Length; )
        {
            if (haystack[i] == needle[j])
            {
                i++; j++;
            }
            else
            {
                i -= j - 1; j = 0;
            }
        }
        return j == needle.Length ? i - j : -1;
    }
}