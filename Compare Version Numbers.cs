public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        string[] a = version1.Split('.');
        string[] b = version2.Split('.');
        if (Toint(a[0]) > Toint(b[0])) return 1;
        if (Toint(a[0]) < Toint(b[0])) return -1;
        if (Toint(a[1]) < Toint(b[1])) return -1;
        else return 0;
    }
    int Toint(string s)
    {
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            res = res * 10 + s[i] - '0';
        }
        return res;
    }
}