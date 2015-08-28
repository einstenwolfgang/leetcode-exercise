public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length < 1) return "";
        string prifix = strs[0];
        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length < 1) return "";
            int len = prifix.Length < strs[i].Length ? prifix.Length : strs[i].Length;
            int j = 0;
            for (j = 0; j < len; j++)
            {
                if (prifix[j] != strs[i][j])
                    break;
            }
            prifix = prifix.Substring(0, j);
        }
        return prifix;
    }
}