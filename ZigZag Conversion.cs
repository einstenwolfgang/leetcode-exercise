public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;
        int i = 0, j, gap = numRows - 2;
        char[] res = new char[numRows];
        while (i < s.Length)
        {
            for (j = 0; i < s.Length && j < numRows; j++) res[j] = s[i++];
            for (j = gap; i < s.Length && j > 0; j--) res[j] = s[i++];
        }
        string str = "";
        for (i = 0; i < numRows; i++)
        {
            str += res[i];
        }
        return str;
    }
}