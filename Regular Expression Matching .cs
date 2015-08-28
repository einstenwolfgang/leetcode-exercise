using System.Text.RegularExpressions;
public class Solution
{
    public bool IsMatch(string s, string p)
    {
        Regex reg = new Regex(@"^" + p + "$");
        return reg.IsMatch(s);
    }
}