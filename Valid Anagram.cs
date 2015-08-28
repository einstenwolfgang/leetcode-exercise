public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        if (s.Length != t.Length) return false;
        for (int i = 0; i < s.Length; i++)
        {
            if (!dic.ContainsKey(s[i])) dic.Add(s[i], 0);
            if (!dic.ContainsKey(t[i])) dic.Add(t[i], 0);
            dic[s[i]]++;
            dic[t[i]]--;

        }
        foreach (char c in dic.Keys)
        {
            if (dic[c] > 0) return false;
        }
        return true;
    }
}