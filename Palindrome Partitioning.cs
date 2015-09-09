public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> res = new List<IList<string>>();
        IList<string> each = new List<string>();
        part(s, each, res);
        return res;
    }

    void part(string s, IList<string> each, IList<IList<string>> res)
    {
        if (s == "")
        {
            res.Add(each);
            return;
        }
        for (int i = 1; i <= s.Length; i++)
        {
            if (isPal(s.Substring(0, i)))
            {
                each.Add(s.Substring(0, i));
                part(s.Substring(i), new List<string>(each), res);
                each.RemoveAt(each.Count - 1);
            }

        }
        return;
    }

    bool isPal(string s)
    {
        if (s == "") return true;
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            if (s[i] == s[j])
            {
                i++;
                j--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}